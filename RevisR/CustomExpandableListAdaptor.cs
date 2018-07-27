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
using Java.Lang;

namespace RevisR
{
    public class CustomExpandableListAdaptor : BaseExpandableListAdapter
    {
        readonly Context context;
        readonly List<string> headings;
        readonly Dictionary<string, List<string>> map;

        public CustomExpandableListAdaptor(Context context, List<string> headings, Dictionary<string, List<string>> map)
        {
            this.context = context;
            this.headings = headings;
            this.map = map;
        }

        public override int GroupCount => headings.Count;

        public override bool HasStableIds => false;

        public override Java.Lang.Object GetChild(int groupPosition, int childPosition)
        {
            var success = map.TryGetValue(headings[groupPosition], out var obj);
            var child = obj[childPosition];
            return success ? child : null;
        }

        public override long GetChildId(int groupPosition, int childPosition)
        {
            return childPosition;
        }

        public override int GetChildrenCount(int groupPosition)
        {
            var success = (map.TryGetValue(headings[groupPosition], out var value));
            return success ? value.Count : 0;
        }

        public override Java.Lang.Object GetGroup(int groupPosition)
        {
            return headings[groupPosition];
        }

        public override long GetGroupId(int groupPosition)
        {
            return groupPosition;
        }

        public override bool IsChildSelectable(int groupPosition, int childPosition)
        {
            return true;
        }

        // VIEWS

        public override View GetGroupView(int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
        {
            var i = groupPosition;
            var title = GetGroup(i).ToString();

            if (convertView == null)
            {
                var inflater = LayoutInflater.FromContext(context);
                convertView = inflater.Inflate(Resource.Layout.expandablelistview_parent, null);
            }

            var parentText = (TextView)convertView.FindViewById(Resource.Id.elvTextParent);

            parentText.SetText(title, TextView.BufferType.Normal);

            return convertView;
        }

        public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
        {
            var item = GetChild(groupPosition, childPosition).ToString();

            if (convertView == null)
            {
                var inflater = LayoutInflater.FromContext(context);
                convertView = inflater.Inflate(Resource.Layout.expandablelistview_child, null);
            }

            var childText = (TextView)convertView.FindViewById(Resource.Id.elvTextChild);

            childText.SetText(item, TextView.BufferType.Normal);

            return convertView;
        }
    }
}