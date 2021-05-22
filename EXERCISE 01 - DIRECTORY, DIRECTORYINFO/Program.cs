using System;
using System.IO;

namespace EXERCISE_01___DIRECTORY__DIRECTORYINFO {
    //-----> START
    ///////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\myfolder";

            try {
                var folders = Directory.EnumerateDirectories(path, ".", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach(string s in folders) {
                    Console.WriteLine(s);
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
