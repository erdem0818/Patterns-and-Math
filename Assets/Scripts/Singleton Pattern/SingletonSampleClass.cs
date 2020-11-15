using UnityEngine;

namespace Singleton
{
    public class SingletonSampleClass
    {
        public static SingletonSampleClass uniqueInstance = null;

        private SingletonSampleClass() {}

        public static SingletonSampleClass GetInstance()
        {
            if(uniqueInstance==null)
            {
                uniqueInstance = new SingletonSampleClass();
            }

            return uniqueInstance;
        }
    }
}