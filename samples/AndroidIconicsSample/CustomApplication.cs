namespace AndroidIconicsSample
{
  using System;
  using Android.App;
  using Android.Runtime;
  using AndroidIconicsSample.Typeface;
  using Mikepenz.Iconics;
  using Mikepenz.Community_material_typeface_library;
  using Mikepenz.Meteocons_typeface_library;
  using Mikepenz.Octicons_typeface_library;

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
    }

    public override void OnCreate()
    {
      base.OnCreate();
    }
  }
}