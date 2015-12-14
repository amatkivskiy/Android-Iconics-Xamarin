using Android.App;
using Android.OS;
using Com.Mikepenz.Iconics.Context;
using Android.Widget;

namespace AndroidIconicsSample
{
	[Activity(Name = "com.amatkivskiy.iconics.sample.OldAutomaticActivity",Label = "@string/title_activity_old_automatic", Theme = "@style/MaterialDrawerTheme.Light.ActionBar")]			
	public class OldAutomaticActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_automatic);

			//set a new text on the textView and set the icon font on it
			FindViewById<TextView>(Resource.Id.test4).Text = "{gmd-favorite} GIF";
		}

		protected override void AttachBaseContext(Android.Content.Context @base)
		{
			//not compatible with Calligraphy
			base.AttachBaseContext(IconicsContextWrapper.Wrap(@base));
		}

	}
}

