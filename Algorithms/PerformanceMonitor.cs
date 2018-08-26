using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class PerformanceMonitor
    {
        /// <summary>
        /// Monitor n methods looped for 'runTimes' times. Process is repeated 'avgOfTimes' times and averaged 
        /// 
        /// - needs accuracy checking - compare with Run method
        /// </summary>
        /// <param name="runTimes"></param>
        /// <param name="methods"></param>
        public static void GetMilliseconds(int loopForTimes, int avgOfTimes, params Action[] methods)
        {
            Stopwatch Timer = new Stopwatch();

            foreach (Action method in methods)
            {
                for (int i = 0; i < avgOfTimes; i++)
                {
                    Timer.Start();

                    for (int j = 0; j < loopForTimes; j++)
                    {
                        method();
                    }

                    Timer.Stop();
                }
                
                Console.WriteLine($"{method.ToString()}: {Timer.Elapsed.TotalMilliseconds / avgOfTimes}");
            }             
        }

        /// <summary>
        /// Monitor a single method once. Process is repeated 'avgOfTimes' times and averaged 
        /// </summary>
        /// <param name="method"></param>
        public static void Run(int avgOfTimes, Action method)
        {
            Stopwatch Timer = new Stopwatch();

            for (int i = 0; i < avgOfTimes; i++)
            {
                Timer.Start();

                method();

                Timer.Stop();
            }

            Console.WriteLine($"{method.ToString()}: {Timer.Elapsed.TotalMilliseconds / avgOfTimes}");
        }
    }
}
