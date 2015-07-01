namespace AndroidIconicsSample.Adapter
{
  using System.Collections.Generic;
  using Android.Support.V7.Widget;
  using Android.Views;
  using Android.Widget;
  using Mikepenz.Iconics.View;

  public class IconAdapter : RecyclerView.Adapter
  {
    private List<string> icons;
    private int rowLayout;

    public IconAdapter(List<string> icons, int rowLayout)
    {
      this.icons = icons;
      this.rowLayout = rowLayout;
    }

    public void SetIcons(List<string> icons)
    {
      this.icons.AddRange(icons);
      this.NotifyItemRangeChanged(0, icons.Count - 1);
    }

    public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
    {
      var icon = this.icons[position];
      var viewHolder = holder as CustomViewHolder;

      viewHolder.Image.SetIcon(icon);
      viewHolder.Name.Text = icon;
    }

    public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
    {
      View v = LayoutInflater.From(parent.Context).Inflate(this.rowLayout, parent, false);
      return new CustomViewHolder(v);
    }

    public override int ItemCount
    {
      get
      {
        return this.icons.Count;
      }
    }
  }

  public class CustomViewHolder : RecyclerView.ViewHolder
  {
    public TextView Name;
    public IconicsImageView Image;

    public CustomViewHolder(View itemView)
      : base(itemView)
    {
      this.Name = itemView.FindViewById<TextView>(Resource.Id.name);
      this.Image = itemView.FindViewById<IconicsImageView>(Resource.Id.icon);
    }

  }
}