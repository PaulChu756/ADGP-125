using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Singleton<T> where T : class, new() // where T : class, can only use class
{
    // abstract classes cannot be instantiate.
    private static T _instance;
    public static T instance
    {
      get
        {
            if(_instance == null) // if instance doesn't exist yet
                _instance = new T();
            
            return _instance;
        }
    }
}

