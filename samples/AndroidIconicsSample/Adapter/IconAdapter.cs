namespace AndroidIconicsSample.Adapter
{
	using System.Collections.Generic;
	using Android.Support.V7.Widget;
	using Android.Views;
	using Android.Widget;
	using Mikepenz.Iconics.View;
	using Android.Graphics;
	using Mikepenz.MaterialDrawer.Utils;
	using Android.OS;
	using Android.Text;
	using Android.Content;
	using System;

	public class IconAdapter : RecyclerView.Adapter
	{
		Random random = new Random ();
		List<string> icons;
		int rowLayout;


		public bool Randomize {
			get;
			set;
		}

		public IconAdapter (bool randomize, List<string> icons, int rowLayout)
		{
			this.Randomize = randomize;
			this.icons = icons;
			this.rowLayout = rowLayout;
		}

		public void SetIcons(bool randomize, List<string> icons) {
			this.Randomize = randomize;
			this.icons.AddRange(icons);
			this.NotifyItemRangeInserted(0, icons.Count - 1);
		}

		public override void OnBindViewHolder (RecyclerView.ViewHolder holder, int position)
		{
			var icon = this.icons [position];
			var viewHolder = holder as ViewHolder;

			viewHolder.Image.SetIcon (icon);
			viewHolder.Name.Text = icon;

			if (Randomize) {

				viewHolder.Image.SetColorRes(GetRandomColor(position));
				viewHolder.Image.SetPaddingDp(random.Next(12));

				viewHolder.Image.SetContourWidthDp(random.Next(2));
				viewHolder.Image.SetContourColor(GetRandomColor(position - 2));


				int y = random.Next(10);
				if (y % 4 == 0) {
					viewHolder.Image.SetBackgroundColorRes(GetRandomColor(position - 4));
					viewHolder.Image.SetRoundedCornersDp(2 + random.Next(10));
				}
			}
		}

		int GetRandomColor (int i)
		{
			//make sure w are > 0
			if (i < 0) {
				i = i * (-1);
			}

			//get a random color
			if (i % 10 == 0) {
				return Resource.Color.md_black_1000;
			} else if (i % 10 == 1) {
				return Resource.Color.md_blue_500;
			} else if (i % 10 == 2) {
				return Resource.Color.md_green_500;
			} else if (i % 10 == 3) {
				return Resource.Color.md_red_500;
			} else if (i % 10 == 4) {
				return Resource.Color.md_orange_500;
			} else if (i % 10 == 5) {
				return Resource.Color.md_pink_500;
			} else if (i % 10 == 6) {
				return Resource.Color.md_amber_500;
			} else if (i % 10 == 7) {
				return Resource.Color.md_blue_grey_500;
			} else if (i % 10 == 8) {
				return Resource.Color.md_orange_500;
			} else if (i % 10 == 9) {
				return Resource.Color.md_yellow_500;
			}

			return 0;
		}

		public override RecyclerView.ViewHolder OnCreateViewHolder (ViewGroup parent, int viewType)
		{
			View v = LayoutInflater.From (parent.Context).Inflate (this.rowLayout, parent, false);
			return new ViewHolder (v);
		}

		public void Clear() {
			icons.Clear();
		}

		public override int ItemCount {
			get {
				return this.icons.Count;
			}
		}
	}

	public class ViewHolder : RecyclerView.ViewHolder, View.IOnTouchListener
	{
		public TextView Name;
		public IconicsImageView Image;

		PopupWindow popup;

		public ViewHolder (View itemView) : base (itemView)
		{
			Name = itemView.FindViewById<TextView> (Resource.Id.name);
			Image = itemView.FindViewById<IconicsImageView> (Resource.Id.icon);

			itemView.SetOnTouchListener (this);
		}

		public bool OnTouch (View view, MotionEvent motionEvent)
		{
			var a = motionEvent.Action;
			if (a == MotionEventActions.Down) {
				if (popup != null && popup.IsShowing) {
					popup.Dismiss ();
				}
				ImageView imageView = new ImageView (view.Context);
				imageView.SetImageDrawable (
					Image.Icon.Clone ().SizeDp (144).PaddingDp (8).BackgroundColor (Color.ParseColor ("#DDFFFFFF")).RoundedCornersDp (12)
				);
				int size = (int)UIUtils.ConvertDpToPixel (144, view.Context);
				popup = new PopupWindow (imageView, size, size);
				popup.ShowAsDropDown (ItemView);
			
				//copy to clipboard
				if (Build.VERSION.SdkInt < BuildVersionCodes.Honeycomb) {
					var clipboard = (Android.Text.ClipboardManager)view.Context.GetSystemService (Context.ClipboardService);
					clipboard.Text = Image.Icon.Icon.FormattedName;
				} else {
					var clipboard = (Android.Content.ClipboardManager)view.Context.GetSystemService (Context.ClipboardService);
					ClipData clip = ClipData.NewPlainText ("Android-Iconics icon", Image.Icon.Icon.FormattedName);
					clipboard.PrimaryClip = clip;
				}
			} else if (a == MotionEventActions.Up || a == MotionEventActions.Cancel || a == MotionEventActions.Outside) {
				if (popup != null && popup.IsShowing) {
					popup.Dismiss ();
				}
			}
			return false;
		}
	}
}