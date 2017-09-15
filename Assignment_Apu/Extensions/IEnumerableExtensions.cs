using Caliburn.Micro;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_Apu.Extensions
{
    /// <summary>
    /// Static class for converting the BindableCollections to arrays.
    /// </summary>
    public static class IEnumerableExtensions
    {
        public static BindableCollection<TValue> AsBindable<TValue>(this IEnumerable<TValue> @this)
        {
            return new BindableCollection<TValue>(@this.ToArray());
        }
    }
}
