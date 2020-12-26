using System;
using System.Collections.Generic;
using System.Threading;

namespace FBAppCore.ThreadingUtils
{
    public class ThreadRunner
    {
        public ThreadRunner()
        {
        }

        public void RunMethodsAsSeperateThreads(IEnumerable<Action> i_MethodsToRun)
        {
            foreach(Action method in i_MethodsToRun)
            {
                new Thread(new ThreadStart(method)).Start();
            }
        }

        public void RunMethodAsSeperateThread(Action i_MethodToRun)
        {
            new Thread(new ThreadStart(i_MethodToRun)).Start();
        }
    }
}
