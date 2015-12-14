using Android.Support.V7.Widget;
using Android.Widget;

namespace AndroidIconicsSample
{
  using System.Collections.Generic;
  using System.Linq;
  using Android.App;
  using Android.Graphics;
  using Android.Support.V7.App;
  using Android.OS;
  using Android.Views;
  using Mikepenz.Iconics;
  using Mikepenz.Iconics.Typeface;
  using Mikepenz.MaterialDrawer;
  using Mikepenz.MaterialDrawer.Models;
  using Mikepenz.MaterialDrawer.Models.Interfaces;
	using Android.Text;
	using System;
	using Mikepenz.Fonts;
  using Toolbar = Android.Support.V7.Widget.Toolbar;

	[Activity(Name = "com.amatkivskiy.iconics.sample.MainActivity", MainLauncher = true, Label = "@string/app_name")]
	class MainActivity : AppCompatActivity, Android.Support.V7.Widget.SearchView.IOnQueryTextListener
  {
		IconsFragment mIconsFragment;
		bool mRandomize;
		List<ITypeface> mFonts;

    protected override void OnCreate(Bundle savedInstanceState)
    {
      base.OnCreate(savedInstanceState);
      this.SetContentView(Resource.Layout.activity_main);

      Toolbar toolbar = this.FindViewById<Toolbar>(Resource.Id.toolbar);
      this.SetSupportActionBar(toolbar);
      this.SupportActionBar.SetDisplayHomeAsUpEnabled(false);

			//order fonts by their name
			mFonts = Iconics.GetRegisteredFonts(this).ToList();
			mFonts.Sort((x, y) => x.FontName.CompareTo(y.FontName));
//
//			//add all icons of all registered Fonts to the list
			List<IDrawerItem> items = new List<IDrawerItem>(Iconics.GetRegisteredFonts(this).Count);
			foreach (var font in mFonts) {
				var pdi = new PrimaryDrawerItem();

				pdi.WithName(font.FontName);
				pdi.WithBadge("" + font.Icons.Count);
				pdi.WithDescription(TextUtils.IsEmpty(font.Author) ? font.Version : font.Version + " - " + font.Author);

//				Implement after release of new version of MaterialDrawer.
//				pdi.withBadgeStyle(
//						new BadgeStyle().withColorRes(R.color.md_grey_200)
//				);

				pdi.WithIcon(
						GetRandomIcon(font)
					);

				if (font.MappingPrefix == "gmd") {
					pdi.WithIdentifier(1);
				}
				items.Add(pdi);
			}

      new DrawerBuilder().WithActivity(this)
              .WithToolbar(toolbar)
              .WithDrawerItems(items)
              .WithOnDrawerItemClickListener(new DrawerListener(this))
              .WithFireOnInitialOnClick(true)
              .WithSelectedItem(1)
              .Build();
    }

		IIcon GetRandomIcon(ITypeface typeface) {
			int random = new Random().Next(typeface.Icons.Count);

			return typeface.GetIcon(typeface.Icons.ElementAt(random));
		}

    public override bool OnCreateOptionsMenu(IMenu menu)
    {
			MenuInflater.Inflate(Resource.Menu.menu_main, menu);
//
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Honeycomb) {
				var searchView = (Android.Support.V7.Widget.SearchView) menu.FindItem(Resource.Id.search).ActionView;
				searchView.SetOnQueryTextListener(this);
			} else {
				menu.FindItem(Resource.Id.search).SetVisible(false);
			}
//
			var menuItem = menu.FindItem(Resource.Id.action_opensource);
			menuItem.SetIcon(new IconicsDrawable(this, FontAwesome.Icon.FawGithub).ActionBar().Color(Color.White));
			return base.OnCreateOptionsMenu(menu);
    }

		public bool OnQueryTextChange(string newText)
		{
			Search(newText);
			return true;
		}

		public bool OnQueryTextSubmit(string query)
		{
			Search(query);
			return true;
		}

		void Search(string s) {
			if (mIconsFragment != null) mIconsFragment.OnSearch(s);
		}

    public override bool OnOptionsItemSelected(IMenuItem item)
    {
			switch (item.ItemId) {
				case Resource.Id.action_randomize:
					item.SetChecked(!item.IsChecked);
					mIconsFragment.Randomize(item.IsChecked);
					mRandomize = item.IsChecked;
					return true;
				case Resource.Id.action_opensource:
//					new LibsBuilder()
//						.withFields(R.string.class.getFields())
//						.withLicenseShown(true)
//						.withActivityTitle(getString(R.string.action_opensource))
//						.withActivityTheme(R.style.AppTheme)
//						.withActivityStyle(Libs.ActivityStyle.LIGHT_DARK_TOOLBAR)
//						.start(MainActivity.this);
//
					return true;
				case Resource.Id.action_playground:
					StartActivity(typeof(PlaygroundActivity));
					return true;
				case Resource.Id.action_automatic:
					StartActivity(typeof(AutomaticActivity));
					return true;
				case Resource.Id.action_old_automatic:
					StartActivity(typeof(OldAutomaticActivity));
					return true;
				default:
					return base.OnOptionsItemSelected(item);
			}
    }

    void LoadIcons(string fontName)
    {
      Android.Support.V4.App.FragmentTransaction ft = this.SupportFragmentManager.BeginTransaction();

			mIconsFragment = IconsFragment.NewInstance(fontName);
			mIconsFragment.Randomize(mRandomize);

			ft.Replace(Resource.Id.content, mIconsFragment);
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
				var font = this.activity.mFonts.ElementAt(position);

        this.activity.LoadIcons(font.FontName);
        this.activity.SupportActionBar.Title = font.FontName;

        return false;
      }
    }
  }
}