using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FidroxAssetMS.Extension
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this IEnumerable<T> Items)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem
            {
                Text = "---------Select--------",
                Value = ""
            };
            list.Add(sli);
            foreach (var Item in Items)
            {
                sli = new SelectListItem
                {
                    Text = Item.GetPropertyValue("Name"),
                    Value = Item.GetPropertyValue("Id") 
                    //Text = Item.GetType().GetProperty("Name").GetValue(Item,null).ToString(),
                    //Value = Item.GetType().GetProperty("Id").GetValue(Item, null).ToString()
                };
                list.Add(sli);
            }
            return list;
        }

    }
}
