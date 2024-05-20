using System.Diagnostics;

namespace DelegatesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProcessManager pMgr = new ProcessManager();

            // Client Developer 1 : Display all process
            //ProcessManager.ShowProcessList(FilterByNone);

            ProcessManager.ShowProcessList(delegate { return true; });

            ProcessManager.ShowProcessList((p) => true);

            // Client Developer 2 : Display all Process starts with some alphabet
            //Program p = new Program();
            //FilterDelegate filterDelegate = new FilterDelegate(p.FilterByName);
            FilterDelegate filterDelegate = FilterByName;

            ProcessManager.ShowProcessList(filterDelegate);

            // Anonymous Delegates

            ProcessManager.ShowProcessList(
               delegate (Process p)
               {
                   return p.ProcessName.StartsWith("S");
               }
            );

            // Lambda Expression => Light weight syntax for anonymous delegates
            // Lambda Statement
            // Lambda Expressions
            ProcessManager.ShowProcessList(
               (Process p) =>

                  p.ProcessName.StartsWith("S")

           );

            // Lambda Expressions 1
            ProcessManager.ShowProcessList((Process p) => p.ProcessName.StartsWith("S"));


            // Lambda Expressions 2
            ProcessManager.ShowProcessList(x => x.ProcessName.StartsWith("S"));


            // Client 3 : Display all process having memory morethan 100MB
            ProcessManager.ShowProcessList(FilterByMemSize);

            ProcessManager.ShowProcessList(p => p.WorkingSet64 >= 34234234234);

            // Client 4 : Display all process filterd by threds
            //ProcessManager.ShowProcessList(5);
        }

        // Cleint 1
        //public static bool FilterByNone(Process p)
        //{
        //    return true;
        //}


        // Client 3
        public static bool FilterByMemSize(Process p)
        {
            return p.WorkingSet64 >= 200 * 1024 * 1024L;
        }

        // client 2
        public static bool FilterByName(Process p)
        {
            return p.ProcessName.StartsWith("S");
        }


    }

    // Backend Developer

    // declare the delegate

    public delegate bool FilterDelegate(Process p);
    public class ProcessManager
    {
        //public static void ShowProcessList()
        //{
        //    foreach (Process p in Process.GetProcesses())
        //    {
        //        Console.WriteLine(p.ProcessName);
        //    }
        //}

        public static void ShowProcessList(FilterDelegate filter)
        {
            foreach (Process p in Process.GetProcesses())
            {
                // add filter logic
                //if (p.ProcessName.StartsWith(sw))
                if (filter(p))
                {
                    Console.WriteLine(p.ProcessName);
                }
            }
        }

        //public static void ShowProcessList(long size)
        //{
        //    foreach (Process p in Process.GetProcesses())
        //    {
        //        // add filter logic
        //        if (p.WorkingSet64 >= size)
        //        {
        //            Console.WriteLine(p.ProcessName);
        //        }
        //    }
        //}
    }
}
