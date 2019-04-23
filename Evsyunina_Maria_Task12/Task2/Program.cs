using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp9
{
	class Program
	{
		public static string pathToOriginal = @"D:\Evsyunina_Maria_Task12\Originals";
		public static string pathToAllBackups = @"D:\Evsyunina_Maria_Task12\Backups\";
		static void Main(string[] args)
		{
			Console.WriteLine("Выберите режим работы: 1- режим наблюдения; 2 - режим отката изменений");

			int mode = int.Parse(Console.ReadLine());

			switch (mode)
			{
				case 1:
					WorkInMode1.DoCase1();
					break;

				case 2:
					Console.WriteLine("Какой документ необходимо восстановить?");
					BackupWork.ShowOriginalFiles(pathToOriginal);
					int docnum = int.Parse(Console.ReadLine());
					Console.WriteLine("Какую версию необходимо восстановить?");
					BackupWork.ShowVersions(docnum, pathToOriginal, pathToAllBackups);
					int versionum = int.Parse(Console.ReadLine());
					BackupWork.FileRecover(docnum, versionum, pathToOriginal, pathToAllBackups);

					break;
			}


		}
	}
}
