namespace AndroidIconicsSample.Typeface
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using Android.Graphics;
  using Android.Util;
  using Mikepenz.Iconics.Typeface;

  public class CustomFont : Java.Lang.Object, ITypeface
  {
    const string TtfFile = "fontello.ttf";

    static Typeface _typeface = null;

    static Dictionary<string, Java.Lang.Character> _chars;

    public IIcon GetIcon(string key)
    {
      return Icon.Values.ToList().Find(icon => icon.Name.Equals(key));
    }

    public IDictionary<string, Java.Lang.Character> Characters
    {
      get
      {
        return _chars ?? (_chars = Icon.Values.ToDictionary(icon => icon.Name, icon => new Java.Lang.Character(icon.Character)));
      }
    }

    public Typeface GetTypeface(Android.Content.Context context)
    {
      if (_typeface == null)
      {
        try
        {
          _typeface = Typeface.CreateFromAsset(context.Assets, "fonts/" + TtfFile);
        }
        catch (Exception e)
        {
          Log.Error("Iconics", "Failed to load font from Assets: " + e.Message);
        }
      }
      return _typeface;
    }

    public string Author
    {
      get
      {
        return "";
      }
    }

    public string Description
    {
      get
      {
        return "";
      }
    }

    public string FontName
    {
      get
      {
        return "CustomFont";
      }
    }

    public int IconCount
    {
      get
      {
        return _chars.Count;
      }
    }

    public ICollection<string> Icons
    {
      get
      {
        return Icon.Values.Select(icon => icon.Name).ToList();
      }
    }

    public string License
    {
      get
      {
        return "";
      }
    }

    public string LicenseUrl
    {
      get
      {
        return "";
      }
    }

    public string MappingPrefix
    {
      get
      {
        return "fon";
      }
    }

    public string Url
    {
      get
      {
        return "";
      }
    }

    public string Version
    {
      get
      {
        return "";
      }
    }

    public class Icon : Java.Lang.Object, IIcon
    {
      private readonly char character;
      private readonly string name;

      private static ITypeface _typeFace;

      public Icon(char character, string name)
      {
        this.character = character;
        this.name = name;
      }

      public char Character
      {
        get
        {
          return this.character;
        }
      }

      public string FormattedName
      {
        get
        {
          return "{" + this.name + "}";
        }
      }

      public string Name
      {
        get
        {
          return this.name;
        }
      }

      public ITypeface Typeface
      {
        get
        {
          return _typeFace ?? (_typeFace = new CustomFont());
        }
      }

      public static readonly Icon FontTest1 = new Icon('\ue800', "fon_test1");
      public static readonly Icon FontTest2 = new Icon('\ue801', "fon_test2");

      public static IEnumerable<Icon> Values
      {
        get
        {
          yield return FontTest1;
          yield return FontTest2;
        }
      }
    }
  }
}
