using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp9
{
	class BackupCreation
	{
		public static string[] GetAllFilesForBackups(string path)
		{
			string[] textFiles = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
			return textFiles;
		}


		public static void CreateBackupDirectories(string[] textfiles, string pathToAllBackups)
		{
			for (int i = 0; i < textfiles.Length; i++)
			{
				string name = Path.GetFileName(textfiles[i]);
				string pathToDirectory = string.Format("{0}{1}", pathToAllBackups, name);
				if (!Directory.Exists(pathToDirectory))
				{
					DirectoryInfo di = Directory.CreateDirectory(pathToDirectory);
				}
			}
		}

		public static void CreateBackup(string[] textfiles, string pathToAllBackups)
		{
			for (int i = 0; i < textfiles.Length; i++)
			{
				string name = Path.GetFileName(textfiles[i]);
				string copyTo = string.Format($@"{pathToAllBackups}{name}\{DateTime.Now.Day.ToString()}{DateTime.Now.Month.ToString()} {DateTime.Now.Hour.ToString()}{DateTime.Now.Minute.ToString()}{DateTime.Now.Second.ToString()}.txt");
				string copyFrom = string.Format(textfiles[i]);
				File.Copy(copyFrom, copyTo);
			}
		}

		public static void CreateBackup(string filetobackup)
		{
			string name = Path.GetFileName(filetobackup);
			string copyTo = string.Format($@"{Program.pathToAllBackups}{name}\{DateTime.Now.Day.ToString()}{DateTime.Now.Month.ToString()} {DateTime.Now.Hour.ToString()}{DateTime.Now.Minute.ToString()}{DateTime.Now.Second.ToString()}.txt");
			string copyFrom = filetobackup;
			File.Copy(copyFrom, copyTo);
		}

		public static void RenameDirectory(string newpath, string oldpath)
		{
			string name = Path.GetFileName(newpath);
			string nameOld = Path.GetFileName(oldpath);
			string to = string.Format($@"{Program.pathToAllBackups}{name}");
			string from = string.Format($@"{Program.pathToAllBackups}{nameOld}");

			Directory.Move(from, to);
		}
	}
}
