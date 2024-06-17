using System.Collections.Generic;
using System.Linq;

namespace FikaAmazonAPI.Utils
{
    public static class Listing
    {
        public static IList<IList<T>> Slice<T>(IList<T> list, int number)
        {
            IList<IList<T>> objListList = new List<IList<T>>();
            var num = list.Count / number;
            if ((uint)(list.Count % number) > 0U)
                ++num;
            for (var index = 0; index <= num - 1; ++index)
            {
                IList<T> list1 = list.Skip(index * number).Take(number).ToList();
                objListList.Add(list1);
            }

            return objListList;
        }

        public static string GetElementAtIndexOrDefault(this object[] array, int index)
        {
            if (index >= 0 && index < array.Length)
                return array[index].ToString();
            return null;
        }
    }
}