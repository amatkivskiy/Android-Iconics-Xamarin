namespace AndroidIconicsSample
{
  using System;
  using Android.App;
  using Android.Runtime;
  using AndroidIconicsSample.Typeface;
  using Com.Mikepenz.Iconics;

  [Application(Theme = "@style/MaterialDrawerTheme.Light.DarkToolbar")]
  public class CustomApplication : Application
  {
    public CustomApplication(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
    {
      //    Iconics.RegisterFont(new Meteoconcs());
      //    Iconics.RegisterFont(new Octicons());
      //    Iconics.RegisterFont(new CommunityMaterial());
      Iconics.RegisterFont(new CustomFont());
    }

    public override void OnCreate()
    {
      base.OnCreate();
    }
  }
}