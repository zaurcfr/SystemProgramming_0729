using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SystemProgramming_0729
{

    class Program
    {
        static void foo1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Hello for the {i} time");
            }
        }
        static void foo2()
        {
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine($"And then hello for the {i} time");
            }
        }

        static void Main(string[] args)
        {
            #region Process

            //Process.Start("C:\\Users\\cefe_a8xp\\AppData\\Local\\Google\\Chrome\\Application\\chrome", "github.com/zaurcfr");

            //Process myProcess = new Process();
            //myProcess.StartInfo.UseShellExecute = true;
            //myProcess.StartInfo.FileName = "https://github.com/zaurcfr";
            //myProcess.Start();


            //var proc = Process.GetProcessesByName("notepad").FirstOrDefault();
            //proc?.Kill();

            //var processes = Process.GetProcessesByName("notepad");
            //foreach (var item in processes)
            //{
            //    item.Kill();
            //}

            //var process = new Process()
            //{
            //    StartInfo = new ProcessStartInfo
            //    {
            //        FileName = "C:\\Users\\cefe_a8xp\\AppData\\Local\\Google\\Chrome\\Application\\chrome",
            //        Arguments = "github.com/zaurcfr"
            //    }
            //};
            //process.Start();
            //Console.WriteLine(process.StartTime);
            //Console.WriteLine(process.BasePriority);
            //Console.WriteLine(process.ProcessName);
            //Console.WriteLine(process.Handle);
            //Console.WriteLine(process.HandleCount);

            //var process = new Process()
            //{
            //    StartInfo = new ProcessStartInfo
            //    {
            //        FileName = "notepad"
            //    }
            //};
            //process.Start();
            //Console.WriteLine(process.StartTime);
            //Console.WriteLine(process.BasePriority);
            //Console.WriteLine(process.ProcessName);
            //Console.WriteLine(process.Handle);
            //Console.WriteLine(process.HandleCount);
            //var handle = process.MainWindowHandle;
            //PInvoke.User32.MessageBox(handle, "Hello", "Caption", PInvoke.User32.MessageBoxOptions.MB_OKCANCEL);

            //var process = new Process()
            //{
            //    StartInfo = new ProcessStartInfo
            //    {
            //        FileName = "C:\\Users\\cefe_a8xp\\source\\repos\\KontaktHomeWPF\\KontaktHomeWPF\\bin\\Debug\\netcoreapp3.1\\KontaktHomeWPF"
            //    }
            //};

            //var process = Process.GetCurrentProcess();

            //if (Process.GetProcessesByName(process.ProcessName).Count() > 1)
            //{
            //    var handle = Process.GetCurrentProcess().MainWindowHandle;
            //    PInvoke.User32.MessageBox(IntPtr.Zero, "Application is already running", "Error", PInvoke.User32.MessageBoxOptions.MB_OK);
            //    Environment.Exit(0);
            //}

            #endregion

            //var thread = new Thread(foo2);
            //thread.Start();

            //Thread.Sleep(1);

            //foo1();

            //var thread = new Thread(() =>
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //});
            //thread.Start();

            //foo1();

            var thread = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine($"{i}");
                }
            });
            thread.IsBackground = true;
            thread.Start();

        }


    }
}
