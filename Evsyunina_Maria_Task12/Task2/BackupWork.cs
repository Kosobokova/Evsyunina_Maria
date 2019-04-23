using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp9
{
	class BackupWork
	{
		public static void ShowOriginalFiles(string path)
		{
			string[] originalFiles = BackupCreation.GetAllFilesForBackups(path);
			for (int i = 0; i < originalFiles.Length; i++)
			{
				Console.WriteLine($"{i}   {originalFiles[i]}");
			}
		}

		private static string GetBackupDirectory(int docnum, string pathtooriginals, string pathtobackups)
		{
			string[] originalFiles = BackupCreation.GetAllFilesForBackups(pathtooriginals);
			string name = Path.GetFileName(originalFiles[docnum]);
			string pathToDirectory = string.Format(@"{0}{1}\", pathtobackups, name);
			return pathToDirectory;
		}

		public static void ShowVersions(int docnum, string pathtooriginals, string pathtobackups)
		{
			string[] filesToBackup = Directory.GetFiles(GetBackupDirectory(docnum, pathtooriginals, pathtobackups));

			for (int i = 0; i < filesToBackup.Length; i++)
			{
				DateTime timeToShow = File.GetCreationTime(filesToBackup[i]);
				Console.WriteLine($"{i}   {timeToShow}");
			}
		}

		public static void FileRecover(int docnum, int versionum, string pathtooriginals, string pathtobackups)
		{
			string[] filesToBackup = Directory.GetFiles(GetBackupDirectory(docnum, pathtooriginals, pathtobackups));
			string pathToFile = string.Format(filesToBackup[versionum]);
			string[] originalFiles = BackupCreation.GetAllFilesForBackups(pathtooriginals);
			string name = Path.GetFileName(originalFiles[docnum]);
			string pathToOriginal = string.Format(@"{0}{1}", pathtooriginals, name);
			string[] strings = File.ReadAllLines(pathToFile);
			File.WriteAllLines(pathToOriginal, strings);
		}
	}
}