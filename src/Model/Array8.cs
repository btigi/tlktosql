using System;
using System.Runtime.InteropServices;

namespace TlkToSql.Model
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Array8
    {
        public Array8(string value)
        {
            if ((value ?? String.Empty).Length > 8)
            {
                throw new ArgumentException(value);
            }
            character1 = (value ?? String.Empty).Length >= 1 ? value[0] : '\0';
            character2 = (value ?? String.Empty).Length >= 2 ? value[1] : '\0';
            character3 = (value ?? String.Empty).Length >= 3 ? value[2] : '\0';
            character4 = (value ?? String.Empty).Length >= 4 ? value[3] : '\0';
            character5 = (value ?? String.Empty).Length >= 5 ? value[4] : '\0';
            character6 = (value ?? String.Empty).Length >= 6 ? value[5] : '\0';
            character7 = (value ?? String.Empty).Length >= 7 ? value[6] : '\0';
            character8 = (value ?? String.Empty).Length >= 8 ? value[7] : '\0';
        }

        public char character1;
        public char character2;
        public char character3;
        public char character4;
        public char character5;
        public char character6;
        public char character7;
        public char character8;

        public override string ToString()
        {
            var x = String.Format("{0}{1}{2}{3}{4}{5}{6}{7}", character1, character2, character3, character4, character5, character6, character7, character8);
            x = x.Substring(0, x.IndexOf('\0') >= 0 ? x.IndexOf('\0') : x.Length);
            return x;
        }
    }
}