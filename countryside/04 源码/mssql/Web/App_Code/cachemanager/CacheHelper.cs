using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Kevin.Framework.Cache;


public class CacheHelper : CacheQueue<string, object>
    {
        static ReaderWriterLock rwLock = new ReaderWriterLock();
        private static object syncLock = new object();
        private static CacheHelper instance = null;
        //实现单例模式
        private CacheHelper() { }

        public static CacheHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncLock)
                    {
                        if (instance == null)
                            instance = CacheManager.GetInstance<CacheHelper>();
                    }
                }
                return CacheHelper.instance;
            }
        }

        public new void Add(string cacheKey, object obj)
        {
            try
            {
                if (!instance.Contains(cacheKey))
                {
                    base.Add(cacheKey, obj);
                }
            }
            finally
            {

            }
        }

        public object GetData(string cacheKey)
        {
            object result = new object();
            if (base.TryGetValue(cacheKey, out result))
            {
                return result;
            }
            return result;
        }

        public new void Remove(string cacheKey)
        {
            base.Remove(cacheKey);
            //instance.Remove(cacheKey);
        }

        public bool Contains(string cacheKey)
        {
            try
            {
                return base.ContainsKey(cacheKey);
            }
            finally
            {

            }
        }
    }
 
