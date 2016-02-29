using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
    public static class Helper
    {

        /// <summary>
        /// Converts the specified ',' separated string to list of elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public static List<T> Convert<T>(this string list)
        {
            List<T> result = new List<T>();
            string[] elements = list.Split(',');

            T temp;
            foreach (string str in elements)
            {
                temp = ConvertFromString<T>(str);
                result.Add(temp);
            }
            return result;
        }

        /// <summary>
        /// Converts from string.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="stringInput">The string input.</param>
        /// <returns></returns>
        public static T ConvertFromString<T>(string stringInput)
        {
            T result = default(T);

            TypeConverter typeConverter = TypeDescriptor.GetConverter(typeof(T));

            if (typeConverter != null)
            {
                result = (T)typeConverter.ConvertFromString(stringInput);
            }

            return result;
        }
    }
}
