namespace AndroidIconicsSample
{
  using Android.Support.V7.Widget;
  using System.Collections.Generic;
  using Android.View;
  using Android.Views;
  using Android.Widget;

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
      this.NotifyDataSetChanged();
    }

    public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
    {
      var icon = this.icons[position];

      var vh = holder as ViewHolder;

      vh.Image.SetIcon(icon);
      vh.Name.Text = icon;
    }

    public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
    {
      View v = LayoutInflater.From(parent.Context).Inflate(this.rowLayout, parent, false);
      return new ViewHolder(v);
    }

    public override int ItemCount
    {
      get
      {
        return this.icons == null ? 0 : this.icons.Count;
      }
    }
  }

  public class ViewHolder : RecyclerView.ViewHolder
  {
    public TextView Name { get; private set; }
    public IconicsImageView Image { get; private set; }

    public ViewHolder(View itemView)
      : base(itemView)
    {
      this.Name = itemView.FindViewById<TextView>(Resource.Id.name);
      this.Image = itemView.FindViewById<IconicsImageView>(Resource.Id.icon);
    }
  }
}
