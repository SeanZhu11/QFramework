﻿//mcs -r:/Applications/Unity/Unity.app/Contents/Managed/UnityEngine.dll -sdk:2 -target:library Log.cs
using System;
using UnityEngine;

namespace QFramework
{
    public enum LogLevel
    {
        None = 0,
        Exception = 1,
        Error = 2,
        Warning = 3,
        Normal = 4,
        Max = 5
    }

    public class Log
    {
        private static LogLevel mLogLevel = LogLevel.Normal;

        public static LogLevel Level
        {
            get { return mLogLevel; }
            set { mLogLevel = value; }
        }

        public static void i(object msg)
        {
            if (mLogLevel < LogLevel.Normal)
            {
                return;
            }
            Debug.Log(msg);
        }

        public static void i(string msg, params object[] args)
        {
            if (mLogLevel < LogLevel.Normal)
            {
                return;
            }
            Debug.LogFormat(msg, args);
        }

        public static void e(object msg)
        {
            if (mLogLevel < LogLevel.Error)
            {
                return;
            }
            Debug.LogError(msg);
        }

        public static void e(Exception e)
        {
            if (mLogLevel < LogLevel.Exception)
            {
                return;
            }
            Debug.LogException(e);
        }

        public static void e(string msg, params object[] args)
        {
            if (mLogLevel < LogLevel.Error)
            {
                return;
            }
            Debug.LogErrorFormat(msg, args);
        }

        public static void w(object msg)
        {
            if (mLogLevel < LogLevel.Warning)
            {
                return;
            }
            Debug.LogWarning(msg);
        }

        public static void w(string msg, params object[] args)
        {
            if (mLogLevel < LogLevel.Warning)
            {
                return;
            }
            Debug.LogWarningFormat(msg, args);
        }
    }
}