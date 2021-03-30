using System;
using System.IO;

namespace filw_watcher
{
    class FileCopy {
        public  void FileCopyToDest(string fileName){
            string currentMonth = DateTime.Now.Month.ToString();
            string currentYear = DateTime.Now.Year.ToString();
            string destPath = Path.Combine(@"/home/javorkabotond/proba2", currentYear,currentMonth);
            // File.Copy(Path.Combine(@"/home/javorkabotond/proba", fileName), Path.Combine(@"/home/javorkabotond/proba2", fileName));
            if (!Directory.Exists(destPath))
            {
                Directory.CreateDirectory(destPath);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(destPath));
                File.Copy(Path.Combine(@"/home/javorkabotond/proba", fileName), Path.Combine(destPath,fileName));
            }
            else {
                File.Copy(Path.Combine(@"/home/javorkabotond/proba", fileName), Path.Combine(destPath,fileName));
            }
        }
    }
}