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

    static Typeface typeface = null;

    static Dictionary<string, Java.Lang.Character> chars;

    public override string ToString()
    {
      return string.Format("[CustomFontO: TtfFile={0}, typeface={1}, chars={2}, Characters={3}, Author={4}, Description={5}, FontName={6}, IconCount={7}, Icons={8}, License={9}, LicenseUrl={10}, MappingPrefix={11}, Url={12}, Version={13}]", TtfFile, typeface, chars, Characters, Author, Description, FontName, IconCount, Icons, License, LicenseUrl, MappingPrefix, Url, Version);
    }

    public IIcon GetIcon(string key)
    {
      return Icon.Values.Find(icon => icon.Name.Equals(key));
    }

    public IDictionary<string, Java.Lang.Character> Characters
    {
      get
      {
        return chars ?? (chars = Icon.Values.ToDictionary(icon => icon.Name, icon => new Java.Lang.Character(icon.Character)));
      }
    }

    public Typeface GetTypeface(Android.Content.Context context)
    {
      if (typeface == null)
      {
        try
        {
          typeface = Typeface.CreateFromAsset(context.Assets, "fonts/" + TtfFile);
        }
        catch (Exception e)
        {
          Log.Error("Iconics", e.Message);
        }
      }
      return typeface;
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
        return chars.Count;
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
