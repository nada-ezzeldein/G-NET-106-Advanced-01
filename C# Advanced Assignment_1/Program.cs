using System.Security.Cryptography.X509Certificates;

namespace C__Advanced_Assignment_1
{
    #region Question 2
    //           public class Container<T>
    //{
    //    private List<T> items = new List<T>();

    //    public void Add(T item)
    //    {
    //        items.Add(item);
    //    }

    //    public T Get(int index)
    //    {
    //        return items[index];
    //    }
    //}
    #endregion

    #region Question 3
    // Multiple type parameters allow a generic class or method to work with more than one data type.
    //public class Pair <TKey, TValue>
    //{
    //    public TKey Key { get; set; }
    //    public TValue Value { get; set; }
    //    public Pair(TKey key, TValue value)
    //    {
    //        Key = key;
    //        Value = value;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine($"Key: {Key} , Value: {Value}");
    //    }
    //}
    #endregion

    #region Question 4
    // What is a generic method? Write Swap<T> method
    // a method that can operate on different data types while providing type safety.
    //public static class GenericMethods
    //{
    //    public static void Swap<T>(ref T a, ref T b)
    //    {
    //        T temp = a;
    //        a = b;
    //        b = temp;
    //    }
    //}
    #endregion

    #region Question 5
    //public class GenericMethod
    //{        public static T FindMax<T>(T[] array) where T : IComparable<T>
    //    {

    //        T max = array[0];
    //        for (int i = 1; i < array.Length; i++)
    //        {
    //            if (array[i].CompareTo(max) > 0)
    //            {
    //                max = array[i];
    //            }
    //        }
    //        return max;
    //    }
    //}
    #endregion

    #region Question 6
    // interface that can work with different data types while providing type safety.
    //public interface IRepository<T>
    //{
    //    void Add(T entity);
    //    T GetById(int id);
    //    IEnumerable<T> GetAll();
    //    void Remove(T entity);
    //}
    #endregion

    #region Question 7
    // struct constraint restricts a generic type parameter to value types (structs).
    //public class ValueTypeContainer<T> where T : struct
    //{
    //    private List<T> items = new List<T>();
    //    public void Add(T item)
    //    {
    //        items.Add(item);
    //    }
    //    public T Get(int index)
    //    {
    //        return items[index];
    //    }
    //}
    #endregion

    #region Question 8
    // The 'class' constraint restricts a generic type parameter to reference types.

    //public class ReferenceTypeContainer<T> where T : class
    //{
    //    private List<T> items = new List<T>();
    //    public void Add(T item)
    //    {
    //        items.Add(item);
    //    }
    //    public T Get(int index)
    //    {
    //        return items[index];
    //    }
    //}
    #endregion

    #region Question 9
    // It requires that the type parameter has a parameterless constructor.

    //public class ConstructorConstraint<T> where T : new()
    //{
    //    public T CreateInstance()
    //    {
    //        return new T();
    //    }
    //}
    #endregion

    #region Question 10
    // It restricts a generic type parameter to types that implement a specific interface.

    //public interface IMyInterface
    //{
    //    void AnyFunction();
    //}

    //public class MyContainer<T> where T : IMyInterface
    //{
    //    public void ProcessItem(T item)
    //    {
    //        item.AnyFunction();
    //    }
    //}
    #endregion

    #region Question 11
    // It restricts a generic type parameter to types that inherit from a specific base class.

    //public class BaseClass
    //{
    //    public void BaseMethod()
    //    {
    //        Console.WriteLine("Base method called.");
    //    }
    //}
    //public class Processor<T> where T : BaseClass
    //{
    //    public void Process(T item)
    //    {
    //        item.BaseMethod();
    //    }
    //}
    #endregion

    #region Question 12
    // by separating them with commas in the where clause.
    //public class MultiConstraint<T> where T : BaseClass, IMyInterface, new()
    //{
    //    public void _Item(T item)
    //    {
    //        item.BaseMethod();
    //        item.AnyFunction();
    //    }
    //}
    #endregion

    #region Question 13
    // It is used to obtain the default value of a type parameter.

    //public class DefaultExample<T>
    //{
    //    public T GetDefaultValue()
    //    {
    //        return default(T);
    //    }
    //}

    #endregion

    #region Question 14
    //public class SafeList<T>
    //{
    //    private List<T> items = new List<T>();
    //    public void Add(T item)
    //    {
    //        items.Add(item);
    //    }
    //    public T Get(int index)
    //    {
    //        if (index < 0 || index >= items.Count)
    //        {
    //            return default(T);
    //        }
    //        return items[index];
    //    }
    //}

    #endregion

    #region Question 15
    // It allows a method to return a more derived type than that specified by the generic parameter.
    // Out keyword is used to specify covariance in generic interfaces and delegates.

    //public interface ICovariant<out T>
    //{
    //    T GetItem();
    //}
    //public class CovariantExample : ICovariant<string>
    //{
    //    public string GetItem()
    //    {
    //        return "Covariance!";
    //    }
    //}

    #endregion

    #region Question 16
    // Contravariance allows a method to accept parameters of a less derived type than that specified by the generic parameter.
    // in keyword is used to specify contravariance in generic interfaces and delegates.

    //public interface IContravariant<in T>
    //{
    //    void ProcessItem(T item);
    //}
    //public class ContravariantExample : IContravariant<object>
    //{
    //    public void ProcessItem(object item)
    //    {
    // Process the item
    //    }
    //}
    #endregion 

    #region Question 17
    // Covariance allows a method to return a more derived type.
    // contravariance allows a method to accept parameters of a less derived type than that specified.

    // public class Animal
    // {
    //     public virtual void Speak()
    //     {
    //         Console.WriteLine("Animal speaks");
    //     }
    // }
    // public class Dog : Animal
    // {
    //     public override void Speak()
    //     {
    //         Console.WriteLine("Dog barks");
    //     }
    // }
    // public class Cat : Animal
    // {
    //     public override void Speak()
    //     {
    // Console.WriteLine("Cat meows");
    //     }
    // }
    // Covariance example
    //======================================================
    // public class CovariantExample : ICovariant<Dog>
    // {
    //     public Dog GetItem()
    //     {
    // return new Dog();
    //     }
    // }
    // Contravariance example
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
