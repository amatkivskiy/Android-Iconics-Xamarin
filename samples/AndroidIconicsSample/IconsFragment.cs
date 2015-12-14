namespace AndroidIconicsSample
{
	using System.Collections.Generic;
	using Android.OS;
	using Android.Support.V4.App;
	using Android.Support.V7.Widget;
	using Android.Views;
	using Android.Util;
	using AndroidIconicsSample.Adapter;
	using Mikepenz.Iconics;

	public class IconsFragment : Fragment
	{
		const string FontName = "FONT_NAME";
		List<string> icons = new List<string>();
		IconAdapter mAdapter;
		bool randomize;
		//
		public static IconsFragment NewInstance(string fontName)
		{
			var bundle = new Bundle();

			var fragment = new IconsFragment();
			bundle.PutString(FontName, fontName);

			fragment.Arguments = bundle;

			return fragment;
		}

		public void Randomize(bool randomize)
		{
			this.randomize = randomize;

			if(this.mAdapter != null) {
				this.mAdapter.Randomize = this.randomize;
				this.mAdapter.NotifyDataSetChanged();
			}
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			return inflater.Inflate(Resource.Layout.icons_fragment, null, false);
		}
		//
		public override void OnViewCreated(View view, Bundle savedInstanceState)
		{
			base.OnViewCreated(view, savedInstanceState);

			RecyclerView mRecyclerView = view.FindViewById<RecyclerView>(Resource.Id.list);
			mRecyclerView.SetLayoutManager(new GridLayoutManager(this.Activity, 2));
			//animator not yet working
			//        mRecyclerView.SetItemAnimator(new SlideInLeftAnimator()); TODO:
			mAdapter = new IconAdapter(this.randomize, new List<string>(), Resource.Layout.row_icon);
			mRecyclerView.SetAdapter(mAdapter);

			if(this.Arguments != null) {
				var fontName = this.Arguments.GetString(FontName);

				foreach(var iTypeface in Iconics.GetRegisteredFonts (this.Context)) {
					if(iTypeface.FontName.Equals(fontName)) {
						if(iTypeface.Icons != null) {
							foreach(var icon in iTypeface.Icons) {
								this.icons.Add(icon);
							}
							mAdapter.SetIcons(randomize, icons);
							break;
						}
					}
				}
			}
		}

		public void OnSearch(string s)
		{
			Log.Info("IconsFragment", "onSearch: " + s);

			List<string> tmpList = new List<string>();
			foreach(var icon in this.icons) {
				if(icon.ToLower().Contains(s.ToLower())) {
					tmpList.Add(icon);
				}
			}
//
			Log.Info("IconsFragment", "icons-size: " + icons.Count + "\n" +
				"tmp-size: " + tmpList.Count);
//
			mAdapter.Clear();
			mAdapter.SetIcons(randomize, tmpList);
			mAdapter.NotifyDataSetChanged();
		}
	}
}
