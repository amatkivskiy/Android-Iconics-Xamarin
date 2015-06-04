namespace AndroidIconicsSample.Typeface
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using Android.Graphics;
  using Android.Util;
  using Com.Mikepenz.Iconics.Typeface;

  public class CustomFont : Java.Lang.Object, ITypeface
  {
    const string TtfFile = "fontello.ttf";

    static Typeface _typeface = null;

    static Dictionary<string, Java.Lang.Character> _chars;

    public IIcon GetIcon(string key)
    {
      return Icon.Values.Find(icon => icon.Name.Equals(key));
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

    public void Dispose()
    {
//      throw new System.NotImplementedException();
    }
  }

  public class Icon : Java.Lang.Object, IIcon
  {
    readonly char character;
    readonly string name;

    static ITypeface _typeFace;

    public Icon(char character, string name)
    {
      this.character = character;
      this.name = name;
    }

    public static List<Icon> Values
    {
      get
      {
        var list = new List<Icon>
        {
          new Icon('\ue800', "fon_test1"),
          new Icon('\ue801', "fon_test2")
        };

        return list;
      }
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
  }
}
