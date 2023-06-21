using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TlkToSql.Database;
using TlkToSql.Model;

namespace TlkToSql
{
    partial class Program
    {
        // "C:\Users\Bastienv\OneDrive\Projects\Baldur's Gate Project\Assets\Dialogs\DLG\IMOEN.DLG"
        // "C:\Users\Bastienv\OneDrive\Projects\Baldur's Gate Project\Assets\Dialogs\TLK\dialog.tlk"

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                ShowUsage();
                return;
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"The tlk file at {args[0]} does not exist");
                return;
            }

            if (!File.Exists(args[1]))
            {
                Console.WriteLine($"The dlg file at {args[0]} does not exist");
                return;
            }

            #region Read TLK file
            var tlkReader = new TlkFileBinaryReader();
            var tlkFile = tlkReader.Read(args[0]);
            Console.WriteLine($"Added {tlkFile.Strings.Count} entries");
            #endregion

            #region Read DLG file
            var dlgReader = new DlgFileBinaryReader();
            var dlgFile = dlgReader.Read(args[1]);
            Console.WriteLine($"Added {dlgFile.States.Count} entries");
            #endregion

            #region Combine both files
            var dialogs = new List<Dialog>();
            foreach (var state in dlgFile.States)
            {
                var dialog = new Dialog()
                {
                    Strref = state.Strref,
                    Text = tlkFile.Strings.Where(y => y.Strref == state.Strref).SingleOrDefault()?.Text,
                };
                dialogs.Add(dialog);
            }
            #endregion
        }

        static void ShowUsage()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("  TlkToSql dialog.tlk character.dlg");
        }
    }
}