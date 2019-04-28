using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //ベンチマーク実行開始
            BenchmarkRunner.Run<BenchmarkTest>();
        }
    }

    //計測したい処理をまとめるクラス
    public class BenchmarkTest
    {
        //計測したい処理
        [Benchmark]
        public void TargetMethodA()
        {
            //計測したい処理
            Enumerable.Range(0, 20)
                .ToList()
                .ForEach(item => Console.WriteLine(item * 2));
        }
    }
}
