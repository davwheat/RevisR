﻿using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;

namespace RevisR
{
    public class CustomExpandableListAdaptor : BaseExpandableListAdapter
    {
        readonly Context context;
        readonly List<string> headings;
        readonly Dictionary<string, List<string>> map;
        readonly Dictionary<int, int> customLayouts;

        public CustomExpandableListAdaptor(Context context, List<string> headings, Dictionary<string, List<string>> map, Dictionary<int, int> customLayouts)
        {
            this.context = context;
            this.headings = headings;
            this.map = map;
            if (customLayouts != null)
            {
                this.customLayouts = customLayouts;
            }
            else
            {
                this.customLayouts = new Dictionary<int, int>();
            }
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
            var newview = convertView;

            if (newview == null)
            {
                var inflater = LayoutInflater.FromContext(context);
                newview = inflater.Inflate(Resource.Layout.expandablelistview_parent, null);
            }

            var parentText = (TextView)newview.FindViewById(Resource.Id.elvTextParent);

            parentText.SetText(title, TextView.BufferType.Normal);

            return newview;
        }

        public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
        {
            var item = GetChild(groupPosition, childPosition).ToString();

            var inflater = LayoutInflater.FromContext(context);
            var newview = inflater.Inflate(customLayouts.TryGetValue(groupPosition, out int layout) ? layout : Resource.Layout.expandablelistview_child, null);

            var childText = (TextView)newview.FindViewById(Resource.Id.elvTextChild);

            childText.SetText(item, TextView.BufferType.Normal);

            return newview;
        }
    }
}