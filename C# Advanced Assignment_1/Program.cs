using System.Security.Cryptography.X509Certificates;

namespace C__Advanced_Assignment_1
{ 
           #region Question 2
                   public class Container<T>
        {
            private List<T> items = new List<T>();

            public void Add(T item)
            {
                items.Add(item);
            }

            public T Get(int index)
            {
                return items[index];
            }
        }
            #endregion
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1
            // Q1: What is a generic class? Why use generics?
            // class that can work with any data type.
            // We use it to provide type safety, code reusability, and performance benefits.
            #endregion

           


    }
    }
}
