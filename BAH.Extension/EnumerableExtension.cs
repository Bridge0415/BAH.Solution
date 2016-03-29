﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Linq
{
    public static class EnumerableExtension
    {
        public static bool AnyOrNull<TSource>(this IEnumerable<TSource> source)
        {
            return source == null ? false : source.Any();
        }//end method

        public static bool AnyOrNull<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return source == null ? false : source.Any(predicate);
        }//end method

        public static TSource FirstOrNullDefault<TSource>(this IEnumerable<TSource> source)
        {
            return AnyOrNull<TSource>(source) ? default(TSource) : source.FirstOrDefault();
        }//end method

        public static TSource FirstOrNullDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return AnyOrNull<TSource>(source) ? default(TSource) : source.FirstOrDefault(predicate);
        }//end method

    }//end class
}//end namespace