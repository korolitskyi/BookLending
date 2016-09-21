using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLending.Classes{
    public static class ExtEnum {
        public static void ConsoleOut<T>(this IEnumerable<T> objectEnum,string prompt = "") where T : Entity {
            Console.WriteLine(
                ToStringExt(objectEnum, prompt));
        }

        public static string ToStringExt<T>(this IEnumerable<T> objectEnum, string prompt) {
            StringBuilder sb = new StringBuilder();
            //sb.Append("\n" + prompt + ":");
            sb.AppendFormat("\n{0}:\n", prompt);
            foreach (T e in objectEnum) {
                LineIndent.Current.Increase();
                sb.AppendFormat("{0}{1}", LineIndent.Current.Value, e.ToString());
                LineIndent.Current.Decrease();
            }
            return sb.ToString();
        }

        public static IEnumerable<T> Filter<T>( this IEnumerable<T> objectEnum,Func<T, bool> selector) {
            foreach (T e in objectEnum) {
                if (selector(e))
                    yield return e;
            }
        }

    }
}
