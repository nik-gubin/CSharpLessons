using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    /// <summary>
    /// Правило дял сортировки ключей в SortedList
    /// </summary>
    class ReversoSort: IComparer
    {
        public int Compare(object x, object y)
        {
            string a = x as string;
            if (a == null)
            {
                return -1;
            }
            string b = y as string;
            if (b == null)
            {
                return -1;
            }
            return b.CompareTo(a);
        }
    }
}
