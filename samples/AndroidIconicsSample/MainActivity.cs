namespace AndroidIconicsSample
{
  using System.Collections.Generic;
  using System.Linq;
  using Android.App;
  using Android.Graphics;
  using Android.Support.V7.App;
  using Android.OS;
  using Android.Views;
  using Android.Widget;
  using Mikepenz.Iconics;
  using Mikepenz.Iconics.Typeface;
  using Mikepenz.MaterialDrawer;
  using Mikepenz.MaterialDrawer.Models;
  using Mikepenz.MaterialDrawer.Models.Interfaces;
  using Toolbar = Android.Support.V7.Widget.Toolbar;

  [Activity(MainLauncher = true, Label = "@string/app_name")]
  class MainActivity : AppCompatActivity
  {
    protected override void OnCreate(Bundle savedInstanceState)
    {
      base.OnCreate(savedInstanceState);
      this.SetContentView(Resource.Layout.activity_main);

      Toolbar toolbar = this.FindViewById<Toolbar>(Resource.Id.toolbar);
      this.SetSupportActionBar(toolbar);
      this.SupportActionBar.SetDisplayHomeAsUpEnabled(false);

      List<IDrawerItem> items = new List<IDrawerItem>(Iconics.RegisteredFonts.Count);

      foreach (var font in Iconics.RegisteredFonts)
      {
        var item = new PrimaryDrawerItem();

        item.WithName(font.FontName);
        items.Add(item);
      }

      new DrawerBuilder().WithActivity(this)
              .WithToolbar(toolbar)
              .WithDrawerItems(items)
              .WithOnDrawerItemClickListener(new DrawerListener(this))
              .WithFireOnInitialOnClick(true)
              .WithSelectedItem(1)
              .Build();
    }

    public override bool OnCreateOptionsMenu(IMenu menu)
    {
      this.MenuInflater.Inflate(Resource.Menu.menu_main, menu);

      var menuItem = menu.FindItem(Resource.Id.action_opensource);

      menuItem.SetIcon(new IconicsDrawable(this, FontAwesome.Icon.FawGithub).SizeDp(48).Color(Color.White));

      return base.OnCreateOptionsMenu(menu);
    }

    public override bool OnOptionsItemSelected(IMenuItem item)
    {
      switch (item.ItemId)
      {

//        case Resource.Id..:
//          //      TODO: Add open libraries support.
//          //                    new .Builder()
//          //                            .withFields(R.string.class.getFields())
//          //                            .withLicenseShown(true)
//          //                            .withActivityTitle(getString(R.string.action_opensource))
//          //                            .withActivityTheme(R.style.AppTheme)
//          //                            .start(MainActivity.this);
//
//          return true;
        case Resource.Id.action_playground:
          this.StartActivity(typeof(PlaygroundActivity));
          return true;

        default:
          return base.OnOptionsItemSelected(item);
      }
    }

    void LoadIcons(string fontName)
    {
      Android.Support.V4.App.FragmentTransaction ft = this.SupportFragmentManager.BeginTransaction();
      ft.Replace(Resource.Id.content, IconsFragment.NewInstance(fontName));
      ft.Commit();
    }

    class DrawerListener : Java.Lang.Object, Drawer.IOnDrawerItemClickListener
    {
      readonly MainActivity activity;

      public DrawerListener(MainActivity activity)
      {
        this.activity = activity;
      }

      public bool OnItemClick(AdapterView adapterView, View view, int position, long l, IDrawerItem drawerItem)
      {
        var font = Iconics.RegisteredFonts.ElementAt(position);

        this.activity.LoadIcons(font.FontName);
        this.activity.SupportActionBar.Title = font.FontName;

        return false;
      }
    }
  }
}