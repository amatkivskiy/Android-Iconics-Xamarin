using Com.Mikepenz.Google_material_typeface_library;

namespace AndroidIconicsSample
{
  using Android.App;
  using Android.OS;
  using Com.Mikepenz.Iconics;
  using Android.Support.V7.Widget;
  using System.Collections.Generic;

  [Activity(Label = "AndroidIconicsSample", MainLauncher = true, Icon = "@drawable/icon")]
  public class MainActivity : Activity
  {
    private const string FontName = "Google Material Design";
    private readonly List<string> icons = new List<string>();

    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);

      // Set our view from the "main" layout resource
      this.SetContentView(Resource.Layout.Main);

      // Init and Setup RecyclerView
      var recyclerView = this.FindViewById<RecyclerView>(Resource.Id.list);
      recyclerView.SetLayoutManager(new GridLayoutManager(this, 2));

      IconAdapter mAdapter = new IconAdapter(new List<string>(), Resource.Layout.row_icon);
      recyclerView.SetAdapter(mAdapter);
      foreach (var registeredFont in Iconics.RegisteredFonts)
      {
        if(registeredFont.Icons != null)
        {
          foreach (var icon in registeredFont.Icons)
          {
            this.icons.Add(icon);
          }
        }
      }
      mAdapter.SetIcons(this.icons);
    }
  }
}


