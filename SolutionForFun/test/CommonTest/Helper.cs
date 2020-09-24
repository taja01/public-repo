using NUnit.Framework;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CommonTest
{
    public static class Helper
    {
        //https://docs.microsoft.com/en-us/globalization/locale/sorting-and-string-comparison
        public static bool IsInAlphabeticalOrder(IList<string> list, string cultureInfo, out string message)
        {
            var compareInfo = CultureInfo.GetCultureInfo(cultureInfo).CompareInfo;
            message = null;
            var current = list.First();
            foreach (var item in list.Skip(1))
            {
                var next = item;
                var sc1 = compareInfo.GetSortKey(current);
                var sc2 = compareInfo.GetSortKey(next);
                var result = SortKey.Compare(sc1, sc2);

                if (result > 0)
                {
                    message = $"Alphabetical order problem: {next} is before the {current}";
                    return false;
                }

                current = next;
            }

            return true;
        }
    }
}
