using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp9
{
	class WorkInMode1
	{
		public static void DoCase1()
		{

			FileSystemWatcher watcher = new FileSystemWatcher();
			watcher.Path = Program.pathToOriginal;
			watcher.Filter = "*.txt";
			watcher.Changed += OnChanged;
			watcher.Created += OnChanged;
			watcher.Deleted += OnChanged;
			watcher.Renamed += OnRenamed;

			string[] files = BackupCreation.GetAllFilesForBackups(Program.pathToOriginal);
			BackupCreation.CreateBackupDirectories(files, Program.pathToAllBackups);
			BackupCreation.CreateBackup(files, Program.pathToAllBackups);

			watcher.EnableRaisingEvents = true;

			Console.ReadKey();
		}


		static void OnChanged(object source, FileSystemEventArgs e)
		{
			Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");

			BackupCreation.CreateBackupDirectories(BackupCreation.GetAllFilesForBackups(Program.pathToOriginal), Program.pathToAllBackups);

			BackupCreation.CreateBackup(e.FullPath);

		}

		static void OnRenamed(object source, RenamedEventArgs e)
		{
			Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");

			BackupCreation.RenameDirectory(e.FullPath, e.OldFullPath);

		}
	}
}
