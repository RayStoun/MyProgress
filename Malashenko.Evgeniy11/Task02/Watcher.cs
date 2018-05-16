using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Permissions;

namespace Task02
{
    class Watcher
    {
        public static string backupPath = Path.Combine(Environment.CurrentDirectory, "BackUp");//путь до папки с бекапа
        public static string directoryPath = Path.Combine(Environment.CurrentDirectory, "ControlDirectory");
        private FileSystemWatcher myWatcher;

        public Watcher()
        {
            Run();
        }

        string GetBackUpPath(string date)
        {
            return Path.Combine(backupPath, date);//
        }
        public  void Run()
        {
            myWatcher = new FileSystemWatcher();
            myWatcher.Path = directoryPath;
            myWatcher.IncludeSubdirectories = true;
            myWatcher.NotifyFilter = NotifyFilters.LastAccess
                | NotifyFilters.FileName
                | NotifyFilters.LastWrite
                | NotifyFilters.CreationTime;
            myWatcher.Filter = "*.txt";//фильтр расширения файлов, которые будет отслеживать программа
            myWatcher.Created += OnCreated;
            myWatcher.Deleted += OnDelete;
            myWatcher.Changed += OnChanged;
            myWatcher.Renamed += OnRenamed;//even running afther renamed.
            myWatcher.EnableRaisingEvents = true;//запускает наш FileSystemWatcher
        }
        private  void OnCreated(Object sender, FileSystemEventArgs e)
        {
            string destination = GetBackUpPath(DateTime.Now.ToString("dd.MM.yyyy\\hh\\mm\\ss"));
            CopyAllFiles(directoryPath, destination );
            Console.WriteLine($"File {e.Name} created in {DateTime.Now.ToLocalTime()}");
        }
        private void OnDelete(Object sender, FileSystemEventArgs e)
        {
            string destination = GetBackUpPath(DateTime.Now.ToString("dd.MM.yyyy\\hh\\mm\\ss"));
            CopyAllFiles(directoryPath, destination);
            Console.WriteLine($"File name - {e.Name} delete in {DateTime.Now.ToLocalTime()}");
        }
        private void OnChanged(Object sender, FileSystemEventArgs e)
        {
            string destination = GetBackUpPath(DateTime.Now.ToString("dd.MM.yyyy\\hh\\mm\\ss"));
            CopyAllFiles(directoryPath, destination);
            Console.WriteLine($"File name {e.Name} changed in {DateTime.Now.ToLocalTime()}");
        }
        private void OnRenamed(Object sender, FileSystemEventArgs e)
        {
            string destination = GetBackUpPath(DateTime.Now.ToString("dd.MM.yyyy\\hh\\mm\\ss"));
            CopyAllFiles(directoryPath, destination);
            Console.WriteLine($"File name -  {e.Name} renamed in {DateTime.Now.ToLocalTime()}");
        }
        private void CopyAllFiles(string source, string destination)
        {
        //    DirectoryInfo dirInfo = new DirectoryInfo(source);
        //    DirectoryInfo destDir = new DirectoryInfo(destination);
        //    destDir.Create();
        //    foreach (FileInfo file in dirInfo.GetFiles("* *",SearchOption.AllDirectories))
        //    {
        //        File.Copy(file.FullName, destination + "\\" + file.Name, true);
        //    }
            foreach (string dir in Directory.GetDirectories(source, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dir.Replace(source, destination));
            }
            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            } 
            foreach (string path in Directory.GetFiles(source, "*.txt", SearchOption.AllDirectories))
            {
                File.Copy(path, path.Replace(source, destination), true);
            }
        }
            
        
        public void Stop()
        {
            Console.WriteLine("Please put q , for exit the program");
            myWatcher.EnableRaisingEvents = false;
            while (Console.Read() != 'q') ;
        }
        public void Start()
        {
            myWatcher.EnableRaisingEvents = true;
            Directory.CreateDirectory(directoryPath);
            Directory.CreateDirectory(backupPath);
        }
        public void Restore(string selectBuckup)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);
            selectBuckup = Path.Combine(backupPath, selectBuckup);
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }
            if (Directory.Exists(selectBuckup))
            {
                CopyAllFiles(selectBuckup, directoryPath);
            }
            else
            {
                throw new ArgumentException("Not current date");
            }
        }
        public void PrintBackUps()
        {
            string[] directs = Directory.GetDirectories(backupPath, "*");
            foreach(string dir in directs)
            {
                Console.WriteLine(Path.GetFileName(dir));
            }
        }
        
    }
}
