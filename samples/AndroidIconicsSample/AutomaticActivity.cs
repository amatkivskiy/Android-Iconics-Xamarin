using Android.App;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Com.Mikepenz.Iconics.Context;
using Android.Widget;

namespace AndroidIconicsSample
{
	[Activity(Name = "com.amatkivskiy.iconics.sample.AutomaticActivity", Label = "@string/title_activity_automatic", Theme = "@style/MaterialDrawerTheme.Light.DarkToolbar")]			
	public class AutomaticActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			//define the IconicsLayoutInflater
			//this is compatible with calligraphy and other libs which wrap the baseContext
			LayoutInflaterCompat.SetFactory(LayoutInflater, new IconicsLayoutInflater(Delegate));

			//call super.onCreate
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_automatic);
//
//			// Handle Toolbar
			Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
			SetSupportActionBar(toolbar);
			SupportActionBar.SetDisplayHomeAsUpEnabled(false);
//
//	FindViewById<TextView>(Resource.Id.test4)nt on it
			FindViewById<TextView>(Resource.Id.test4).Text = "{gmd-favorite} GIF";
		}
	}
}

