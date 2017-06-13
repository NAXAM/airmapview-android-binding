using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using Android.Graphics;

namespace AirMapViewQs.Code
{
    public class LogsAdapter : RecyclerView.Adapter
    {
        private const int VIEW_TYPE_STRING = 1;
        private const int VIEW_TYPE_BITMAP = 2;
        private List<Object> logs = new List<Object>();

        public void AddString(string st)
        {
            logs.Add(st);
            NotifyItemInserted(logs.Count - 1);
        }

        public void AddBitmap(Bitmap bitmap)
        {
            logs.Add(bitmap);
            NotifyItemInserted(logs.Count - 1);
        }

        public void ClearLogs()
        {
            logs.Clear();
            NotifyDataSetChanged();
        }

        public override int GetItemViewType(int position)
        {
            Object log = logs[position];
            if (log.GetType() == typeof(string)) return VIEW_TYPE_STRING;
            else if (log.GetType() == typeof(Bitmap)) return VIEW_TYPE_BITMAP;
            else return 0;
            // i don't know return true is right or wrong :D
        }

        public override int ItemCount { get { return logs.Count; } }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            Object log = logs[position];
            switch (holder.ItemViewType)
            {
                case VIEW_TYPE_STRING:
                    ((StringViewHolder)holder).Bind((string)log);
                    break;
                case VIEW_TYPE_BITMAP:
                    ((BitmapViewHolder)holder).Bind((Bitmap)log);
                    break;
            };
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            switch (viewType)
            {
                case VIEW_TYPE_STRING: return new StringViewHolder(parent);
                case VIEW_TYPE_BITMAP: return new BitmapViewHolder(parent);
            }
            return null;
        }
    }

    public class StringViewHolder : RecyclerView.ViewHolder
    {

        public StringViewHolder(ViewGroup parent) : base(LayoutInflater.FromContext(parent.Context).Inflate(Resource.Layout.list_item_text, parent, false))
        {
        }

        public void Bind(string st)
        {
            ((TextView)ItemView).Text = st;
        }
    }

    public class BitmapViewHolder : RecyclerView.ViewHolder
    {

        public BitmapViewHolder(ViewGroup parent) : base(LayoutInflater.FromContext(parent.Context).Inflate(Resource.Layout.list_item_bitmap, parent, false))
        {
        }

        public void Bind(Bitmap bitmap)
        {
            ((ImageView)ItemView).SetImageBitmap(bitmap);
        }
    }
}