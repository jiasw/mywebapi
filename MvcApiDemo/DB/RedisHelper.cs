using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApiDemo.DB
{
    public class RedisHelper
    {
        private static string host = "localhost";
        private static string elementKey = "testKeyRedis";
        private static object objLocker = new object();
        private static RedisClient _db = null;
        /// <summary>
        /// SqlserverDbsession
        /// </summary>
        public static RedisClient DB
        {
            get
            {
                if (_db == null)
                {
                    lock (objLocker)
                    {
                        _db = new RedisClient(host, 6379, "jiasw");
                    }
                }
                return _db;
            }
        }
    }
}