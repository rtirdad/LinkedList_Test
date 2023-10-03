using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace TestProject1
    {
        public static class Extensions
        {
            public static MyList<TResult> Select<T, TResult>(this MyList<T> source, Func<T, TResult> selector)
            {
                MyList<TResult> resultList = new MyList<TResult>();
                foreach (T item in source)
                {
                    TResult resultItem = selector(item);
                    resultList.Add(resultItem);
                }
                return resultList;
            }

            public static MyList<T> Where<T>(this MyList<T> source, Func<T, bool> predicate)
            {
                MyList<T> resultList = new MyList<T>();
                foreach (T item in source)
                {
                    if (predicate(item))
                    {
                        resultList.Add(item);
                    }
                }
                return resultList;
            }

            public static bool Any<T>(this MyList<T> source, Func<T, bool> predicate)
            {
                foreach (T item in source)
                {
                    if (predicate(item))
                    {
                        return true;
                    }
                }
                return false;
            }

            public static T FirstOrDefault<T>(this MyList<T> source, Func<T, bool> predicate)
            {
                foreach (T item in source)
                {
                    if (predicate(item))
                    {
                        return item;
                    }
                }
                return default(T);
            }

            public static int Count<T>(this MyList<T> source)
            {
                return source.Count();
            }
    }
    }

