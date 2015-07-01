namespace AndroidIconicsSample
{
  using Android.App;
  using Android.Graphics;
  using Android.OS;
  using Android.Text;
  using Android.Text.Style;
  using Android.Widget;
  using Mikepenz.Iconics;
  using Mikepenz.Iconics.Typeface;

  [Activity]
  public class PlaygroundActivity : Activity
  {
    protected override void OnCreate(Bundle savedInstanceState)
    {
      base.OnCreate(savedInstanceState);
      this.SetContentView(Resource.Layout.activity_playground);

      //Show how to style the text of an existing TextView
      TextView tv1 = this.FindViewById<TextView>(Resource.Id.test1);
      new Iconics.IconicsBuilder().Ctx(this)
        .Style(new ForegroundColorSpan(Color.White), new BackgroundColorSpan(Color.Black), new RelativeSizeSpan(2f))
        .StyleFor("faw-adjust", new BackgroundColorSpan(Color.Red), new ForegroundColorSpan(Color.ParseColor("#33000000")), new RelativeSizeSpan(2f))
        .On(tv1)
        .Build();

      //You can also do some advanced stuff like setting an image within a text
      TextView tv2 = this.FindViewById<TextView>(Resource.Id.test5);
      SpannableString sb = new SpannableString(tv2.Text);

      IconicsDrawable d = new IconicsDrawable(this, FontAwesome.Icon.FawAndroid).SizeDp(48).PaddingDp(4);
      sb.SetSpan(new ImageSpan(d, SpanAlign.Bottom), 1, 2, SpanTypes.ExclusiveExclusive);
      tv2.Text = sb.ToString();


      //Set the icon of an ImageView (or something else) as drawable
      ImageView iv2 = this.FindViewById<ImageView>(Resource.Id.test2);
      iv2.SetImageDrawable(new IconicsDrawable(this, FontAwesome.Icon.FawThumbsOUp).SizeDp(48).Color(Color.ParseColor("#aaFF0000")).ContourWidthDp(1));

      //Set the icon of an ImageView (or something else) as bitmap
      ImageView iv3 = this.FindViewById<ImageView>(Resource.Id.test3);
      iv3.SetImageBitmap(new IconicsDrawable(this, new FontAwesome(), FontAwesome.Icon.FawAndroid).Color(Color.ParseColor("#deFF0000")).ToBitmap());

      //Show how to style the text of an existing button (NOT WORKING AT THE MOMENT)
      Button b4 = this.FindViewById<Button>(Resource.Id.test4);
      new Iconics.IconicsBuilder().Ctx(this)
        .Style(new BackgroundColorSpan(Color.Black))
        .Style(new RelativeSizeSpan(2f))
        .Style(new ForegroundColorSpan(Color.White))
        .On(b4)
        .Build();
    }
  }
}