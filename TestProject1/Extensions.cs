using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace TestProject1
    {
        public static class Extensions
        {


        public static MyList<TResult> Select<T, TResult>
            (this MyList<T> source, Func<T, TResult> selector)
        {
            MyList<TResult> resultList = new MyList<TResult>();
            foreach (T item in source)
            {
                TResult resultItem = selector(item);
                resultList.Add(resultItem);
            }
            return resultList;
        }


       public static MyList<T> Where<T>
            (this MyList<T> source, Func<T, bool> predicate)
            {
                MyList<T> List = new MyList<T>();
                foreach (T item in source)
                {
                    if (predicate(item))
                    {
                        List.Add(item);
                    }
                }
                return List;
            }

         /*public static IEnumerable<T> Where<T>(MyList<T> source, Func<T, bool> predicate)
        {
            MyList<T> List = new MyList<T>();
            foreach (T item in source)
                if (predicate(item))
                    yield return item;
        }*/
       
       

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
        
        
        public static MyList<int> GetWordCounts(this MyList<string> source)
        {

            MyList<int> wordCounts = new MyList<int>();

            foreach (string item in source)
            {
                int wordCount = CountWords(item);
                wordCounts.Add(wordCount);
            }

            return wordCounts;
        }

        public static int CountWords(string input)
        {
            string[] words = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            return words.Length;
        }
    }
    }

