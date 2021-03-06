﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozu.Api.Logging
{
    public class DefaultLogger : ILogger
    {
        public bool IsInfoEnabled { get { return true; }  }
        public bool IsWarnEnabled { get { return true; } }
        public bool IsDebugEnabled { get { return true; } }
        public bool IsErrorEnabled { get { return true; } }
        public bool IsFatalEnabled { get { return true; } }

        public Task Info(object message, Exception ex = null, object properties = null)
        {
            return Task.Run( () => Console.WriteLine(message));
		}

        public Task Warn(object message, Exception ex = null, object properties = null)
        {
			return Task.Run(() => Console.WriteLine(message));
		}

        public Task Debug(object message, Exception ex = null, object properties = null)
        {
			return Task.Run(() => Console.WriteLine(message));
		}

        public Task Error(object message, Exception ex = null, object properties = null)
        {
			return Task.Run(() => Console.WriteLine(message));
		}

        public Task Fatal(object message, Exception ex = null, object properties = null)
        {
			return Task.Run(() => Console.WriteLine(message));
		}
    }
}
