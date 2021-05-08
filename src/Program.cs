using System;
using System.IO;
using TlkToSql.Database;

namespace TlkToSql
{
    partial class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                ShowUsage();
                return;
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"Dialog.tlk at {args[0]} does not exist");
                return;
            }

            var tlkReader = new TlkFileBinaryReader();
            var tlkFile = tlkReader.Read(args[0]);

            var dataAccess = new DataAccess("Data Source=iedata.sqlite;Version=3;");
            dataAccess.Setup();
            dataAccess.AddString(tlkFile.Strings, args[1]);
            Console.WriteLine($"Added {tlkFile.Strings.Count} entries");

        }

        static void ShowUsage()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("  TlkToSql dialog.tlk game-name:");
        }
    }
}