using System;
using System.IO;

namespace filw_watcher
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWatcher fw = new FileWatcher();
            fw.Watch();
        }
    }
}
