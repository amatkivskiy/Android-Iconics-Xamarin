namespace Com.Mikepenz.Meteocons_typeface_library
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using Android.Util;
  using Com.Mikepenz.Iconics.Typeface;

  public class Meteoconcs : Java.Lang.Object, ITypeface
  {
    private const string TtfFile = "meteocons.ttf";

    private static Android.Graphics.Typeface _typeface = null;

    private static Dictionary<string, Java.Lang.Character> _chars;

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

    public ICollection<string> Icons
    {
      get
      {
        return Icon.Values.Select(icon => icon.Name).ToList();
      }
    }

    public Android.Graphics.Typeface GetTypeface(Android.Content.Context context)
    {
      if (_typeface == null)
      {
        try
        {
          _typeface = Android.Graphics.Typeface.CreateFromAsset(context.Assets, "fonts/" + TtfFile);
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
        return "Alessio Atzeni";
      }
    }

    public string Description
    {
      get
      {
        return "Meteocons is a set of weather icons, it containing 40+ icons available in PSD, CSH, EPS, SVG, Desktop font and Web font. All icon and updates are free and always will be.";
      }
    }

    public string FontName
    {
      get
      {
        return "Meteocons";
      }
    }

    public int IconCount
    {
      get
      {
        return _chars.Count;
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
        return "met";
      }
    }

    public string Url
    {
      get
      {
        return "http://www.alessioatzeni.com/meteocons/";
      }
    }

    public string Version
    {
      get
      {
        return "1.1.1";
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
          return _typeFace ?? (_typeFace = new Meteoconcs());
        }
      }

      public static readonly Icon MetWindyRainInv = new Icon('\ue800', "met_windy_rain_inv");
      public static readonly Icon MetSnowInv = new Icon('\ue801', "met_snow_inv");
      public static readonly Icon MetSnowHeavyInv = new Icon('\ue802', "met_snow_heavy_inv");
      public static readonly Icon MetHailInv = new Icon('\ue803', "met_hail_inv");
      public static readonly Icon MetCloudsInv = new Icon('\ue804', "met_clouds_inv");
      public static readonly Icon MetCloudsFlashInv = new Icon('\ue805', "met_clouds_flash_inv");
      public static readonly Icon MetTemperature = new Icon('\ue806', "met_temperature");
      public static readonly Icon MetCompass = new Icon('\ue807', "met_compass");
      public static readonly Icon MetNa = new Icon('\ue808', "met_na");
      public static readonly Icon MetCelcius = new Icon('\ue809', "met_celcius");
      public static readonly Icon MetFahrenheit = new Icon('\ue80a', "met_fahrenheit");
      public static readonly Icon MetCloudsFlashAlt = new Icon('\ue80b', "met_clouds_flash_alt");
      public static readonly Icon MetSunInv = new Icon('\ue80c', "met_sun_inv");
      public static readonly Icon MetMoonInv = new Icon('\ue80d', "met_moon_inv");
      public static readonly Icon MetCloudSunInv = new Icon('\ue80e', "met_cloud_sun_inv");
      public static readonly Icon MetCloudMoonInv = new Icon('\ue80f', "met_cloud_moon_inv");
      public static readonly Icon MetCloudInv = new Icon('\ue810', "met_cloud_inv");
      public static readonly Icon MetCloudFlashInv = new Icon('\ue811', "met_cloud_flash_inv");
      public static readonly Icon MetDrizzleInv = new Icon('\ue812', "met_drizzle_inv");
      public static readonly Icon MetRainInv = new Icon('\ue813', "met_rain_inv");
      public static readonly Icon MetWindyInv = new Icon('\ue814', "met_windy_inv");
      public static readonly Icon MetSunrise = new Icon('\ue815', "met_sunrise");
      public static readonly Icon MetSun = new Icon('\ue816', "met_sun");
      public static readonly Icon MetMoon = new Icon('\ue817', "met_moon");
      public static readonly Icon MetEclipse = new Icon('\ue818', "met_eclipse");
      public static readonly Icon MetMist = new Icon('\ue819', "met_mist");
      public static readonly Icon MetWind = new Icon('\ue81a', "met_wind");
      public static readonly Icon MetSnowflake = new Icon('\ue81b', "met_snowflake");
      public static readonly Icon MetCloudSun = new Icon('\ue81c', "met_cloud_sun");
      public static readonly Icon MetCloudMoon = new Icon('\ue81d', "met_cloud_moon");
      public static readonly Icon MetFogSun = new Icon('\ue81e', "met_fog_sun");
      public static readonly Icon MetFogMoon = new Icon('\ue81f', "met_fog_moon");
      public static readonly Icon MetFogCloud = new Icon('\ue820', "met_fog_cloud");
      public static readonly Icon MetFog = new Icon('\ue821', "met_fog");
      public static readonly Icon MetCloud = new Icon('\ue822', "met_cloud");
      public static readonly Icon MetCloudFlash = new Icon('\ue823', "met_cloud_flash");
      public static readonly Icon MetCloudFlashAlt = new Icon('\ue824', "met_cloud_flash_alt");
      public static readonly Icon MetDrizzle = new Icon('\ue825', "met_drizzle");
      public static readonly Icon MetRain = new Icon('\ue826', "met_rain");
      public static readonly Icon MetWindy = new Icon('\ue827', "met_windy");
      public static readonly Icon MetWindyRain = new Icon('\ue828', "met_windy_rain");
      public static readonly Icon MetSnow = new Icon('\ue829', "met_snow");
      public static readonly Icon MetSnowAlt = new Icon('\ue82a', "met_snow_alt");
      public static readonly Icon MetSnowHeavy = new Icon('\ue82b', "met_snow_heavy");
      public static readonly Icon MetHail = new Icon('\ue82c', "met_hail");
      public static readonly Icon MetClouds = new Icon('\ue82d', "met_clouds");
      public static readonly Icon MetCloudsFlash = new Icon('\ue82e', "met_clouds_flash");

      public static IEnumerable<Icon> Values
      {
        get
        {
          yield return MetWindyRainInv;
          yield return MetSnowInv;
          yield return MetSnowHeavyInv;
          yield return MetHailInv;
          yield return MetCloudsInv;
          yield return MetCloudsFlashInv;
          yield return MetTemperature;
          yield return MetCompass;
          yield return MetNa;
          yield return MetCelcius;
          yield return MetFahrenheit;
          yield return MetCloudsFlashAlt;
          yield return MetSunInv;
          yield return MetMoonInv;
          yield return MetCloudSunInv;
          yield return MetCloudMoonInv;
          yield return MetCloudInv;
          yield return MetCloudFlashInv;
          yield return MetDrizzleInv;
          yield return MetRainInv;
          yield return MetWindyInv;
          yield return MetSunrise;
          yield return MetSun;
          yield return MetMoon;
          yield return MetEclipse;
          yield return MetMist;
          yield return MetWind;
          yield return MetSnowflake;
          yield return MetCloudSun;
          yield return MetCloudMoon;
          yield return MetFogSun;
          yield return MetFogMoon;
          yield return MetFogCloud;
          yield return MetFog;
          yield return MetCloud;
          yield return MetCloudFlash;
          yield return MetCloudFlashAlt;
          yield return MetDrizzle;
          yield return MetRain;
          yield return MetWindy;
          yield return MetWindyRain;
          yield return MetSnow;
          yield return MetSnowAlt;
          yield return MetSnowHeavy;
          yield return MetHail;
          yield return MetClouds;
          yield return MetCloudsFlash;
        }
      }
    }
  }
}