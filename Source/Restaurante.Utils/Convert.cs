using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Restaurante.Utils
{
    public static class Convert
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this IEnumerable<T> enumerable, Func<T, string> getText, Func<T, string> getValue)
        {
            return enumerable.Select(x => new SelectListItem { Text = getText(x), Value = getValue(x) });
        }
    }
}
