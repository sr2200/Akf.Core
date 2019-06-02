﻿using Akf.Core.Aspect;
using Akf.Core.Aspect.Parts;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Composition;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Akf.Core.Test.Aspect
{
    [Export(typeof(IAkAspectParts))]
    public class AkTestAspect2 : IAkAspectParts
    {
        public void PreProcess<T>(Guid id, MethodInfo targetMethod, T instance, object[] args)
        {
            //Console.WriteLine($"{targetMethod.Name} を実行します。");

            //List<string> logList = GetLogList();
            //logList.Add($"{targetMethod.Name} を実行します。");
        }

        public void PostProcess<T>(Guid id, MethodInfo targetMethod, T instance, object[] args, object result)
        {
            //Console.WriteLine($"{targetMethod.Name} の実行が終了しました。");

            //List<string> logList = GetLogList();
            //logList.Add($"{targetMethod.Name} の実行が終了しました。");
        }

        public void ExceptionProcess<T>(Guid id, MethodInfo targetMethod, T instance, object[] args, Exception ex)
        {
            //Console.WriteLine("例外が発生しました。");

            //List<string> logList = GetLogList();
            //logList.Add("例外が発生しました。");
        }

        //private static List<string> GetLogList()
        //{
        //    List<string> logList = LocalContext.GetData("AkLog") as List<string>;
        //    if (logList == null)
        //    {
        //        logList = new List<string>();
        //        LocalContext.SetData("AkLog", logList);
        //    }

        //    return logList;
        //}
    }
}