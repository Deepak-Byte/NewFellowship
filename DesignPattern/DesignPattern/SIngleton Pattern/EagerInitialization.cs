//---------------------------------------------------------------------
// <copyright file="EagerSingleton.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern.SIngleton_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is class EagerSingleton.
    /// </summary>
    public sealed class EagerSingleton
    {
        /// <summary>
        /// The counter
        /// </summary>
        private static int counter = 0;
        /// <summary>
        /// Prevents a default instance of the <see cref="EagerSingleton"/> class from being created.
        /// </summary>
        private EagerSingleton()
        {
            counter++;
            Console.WriteLine("value of counter " + counter.ToString());
        }
        private static readonly EagerSingleton eagersingleton = new EagerSingleton();
        /// <summary>
        /// Gets the getsingleton.
        /// </summary>
        /// <value>
        /// The getsingleton.
        /// </value>
        public static EagerSingleton Getsingleton
        {
            get
            {
                return eagersingleton;
            }
        }
        /// <summary>
        /// Yourinformations the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Yourinformation(string data)
        {
            Console.WriteLine(data);
        }
    }

    public sealed class Singletons
    {
        private static int counter = 0;
        private Singletons()
        {
            counter++;
            Console.WriteLine("value of counter " + counter.ToString());
        }
        private static readonly Lazy<Singletons> eagersingleton = new Lazy<Singletons>(() => new Singletons());
        public static Singletons Getsingleton
        {
            get
            {
                return eagersingleton.Value;
            }
        }
        public void Yourinformation(string data)
        {
            Console.WriteLine(data);
        }
    }

    public sealed class ThreadSingletons
    {
        private static int counter = 0;
        private static readonly object obj = new object();
        private ThreadSingletons()
        {
            counter++;
            Console.WriteLine("value of counter " + counter.ToString());
        }
        private static ThreadSingletons eagersingleton = null;
        public static ThreadSingletons Getsingleton
        {
            get
            {
                lock (obj)
                {
                    if (eagersingleton == null)
                        eagersingleton = new ThreadSingletons();
                }
                return eagersingleton;

            }
        }
        public void Yourinformation(string data)
        {
            Console.WriteLine(data);
        }
    }

    public class Sataticblockintialization
    {
        private static int counter = 0;
        private Sataticblockintialization()
        {
            counter++;
            Console.WriteLine("value of counter " + counter.ToString());
        }
        private static Sataticblockintialization staticblockintialization;
        static object XYZ()
        {
            try
            {
                staticblockintialization = new Sataticblockintialization();
            }
            catch (Exception Exception)
            {
                Console.WriteLine("YOUR CLASS IS NOT BEEN CREATED "+Exception.Message);
            }
            return staticblockintialization;
        }

        public void Yourinformation(string data)
        {
            Console.WriteLine(data);
        }
    }

    public class Enumexample
    {
        
    }
}

