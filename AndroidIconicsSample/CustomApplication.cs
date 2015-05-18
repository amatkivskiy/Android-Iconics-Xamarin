namespace AndroidIconicsSample
{
  using System;
  using Android.App;
  using Android.Runtime;

  [Application(Theme = "@style/MaterialDrawerTheme.Light.DarkToolbar")]
  public class CustomApplication : Application
  {
    public CustomApplication(IntPtr javaReference, JniHandleOwnership transfer)
      : base(javaReference, transfer)
    {
    }

    public new void OnCreate()
    {
      base.OnCreate();
      //    Iconics.RegisterFont(new Meteoconcs());
      //    Iconics.RegisterFont(new Octicons());
      //    Iconics.RegisterFont(new CommunityMaterial());
      //    Iconics.RegisterFont(new CustomFont());
      //	TODO:
    }
  }
}