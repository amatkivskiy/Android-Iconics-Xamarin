using Mikepenz.Iconics.Typeface;

namespace AndroidIconicsSample
{
  using System;
  using Android.App;
  using Android.Runtime;
  using AndroidIconicsSample.Typeface;
	using Mikepenz.Typeface;
	using Mikepenz.Iconics;

  [Application(Theme = "@style/AppTheme")]
  public class CustomApplication : Application
  {
    public CustomApplication(IntPtr handle, JniHandleOwnership ownerShip)
      : base(handle, ownerShip)
    {
      Iconics.RegisterFont(new Meteoconcs());
      Iconics.RegisterFont(new Octicons());
      Iconics.RegisterFont(new CommunityMaterial());
      Iconics.RegisterFont(new CustomFont());
			Iconics.RegisterFont(new FontAwesome());
			Iconics.RegisterFont(new GoogleMaterial());

			//Generic font creation process
			GenericFont gf2 = new GenericFont("GenericFont", "SampleGenericFont", "gmf", "fonts/materialdrawerfont.ttf");
			gf2.RegisterIcon("person", '\ue800');
			gf2.RegisterIcon("up", '\ue801');
			gf2.RegisterIcon("down", '\ue802');
			Iconics.RegisterFont(gf2);
    }

    public override void OnCreate()
    {
      base.OnCreate();
    }
  }
}