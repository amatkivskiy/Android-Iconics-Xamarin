namespace AndroidIconicsSample
{
  using System.Collections.Generic;
  using Android.OS;
  using Android.Support.V4.App;
  using Android.Support.V7.Widget;
  using Android.Views;
  using AndroidIconicsSample.Adapter;
  using Com.Mikepenz.Iconics;

  public class IconsFragment : Fragment
  {
    const string FontName = "FONT_NAME";
    readonly List<string> icons = new List<string>();

    public static IconsFragment NewInstance(string fontName)
    {
      Bundle bundle = new Bundle();

      IconsFragment fragment = new IconsFragment();
      bundle.PutString(FontName, fontName);

      fragment.Arguments = bundle;

      return fragment;
    }

    public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
      return inflater.Inflate(Resource.Layout.icons_fragment, null, false);
    }

    public override void OnViewCreated(View view, Bundle savedInstanceState)
    {
      base.OnViewCreated(view, savedInstanceState);

      RecyclerView mRecyclerView = view.FindViewById<RecyclerView>(Resource.Id.list);
      mRecyclerView.SetLayoutManager(new GridLayoutManager(this.Activity, 2));
      //animator not yet working
      //        mRecyclerView.SetItemAnimator(new SlideInLeftAnimator()); TODO:
      IconAdapter adapter = new IconAdapter(new List<string>(), Resource.Layout.row_icon);
      mRecyclerView.SetAdapter(adapter);

      if (this.Arguments != null)
      {
        var fontName = this.Arguments.GetString(FontName);

        foreach (var iTypeface in Iconics.RegisteredFonts)
        {
          if (iTypeface.FontName.Equals(fontName))
          {
            if (iTypeface.Icons != null)
            {
              foreach (var icon in iTypeface.Icons)
              {
                this.icons.Add(icon);
              }
              adapter.setIcons(this.icons);
              break;
            }
          }
        }
      }
    }
  }
}
