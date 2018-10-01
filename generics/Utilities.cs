using System;

namespace generics
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }

    // using generics
    //  - it won't work because a and b are plain objects and compiler doesn't know how to compare them
    //  - that's where we can use 'constraints' : where
    
    // 5 types of constraints:
    //  - interface - where T : IComparable
    //  - class - where T : Product
    //  - value - where T : struct
    //  - reference type - where T : class
    //  - object with default constructor - where T : new()

    //  - 1st example where generic method is created in non generic class and constraint is on a method level
    public class Utilities2
    {
        public T Max<T>(T a, T b) where T : IComparable
        {
            // return a > b ? a : b;
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    //  - 2nd example where generic method is in generic class and constraint is on a class level
    public class Utilities3<T> where T: IComparable, new()
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            // let say you want to instantiate obj first
            // it won't work unless you add new() constraint to class/method
            var obj = new T();
        }
    }
}