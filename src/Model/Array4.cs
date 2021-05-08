using System;
using System.Runtime.InteropServices;

namespace TlkToSql.Model
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Array4
    {
        public char character1;
        public char character2;
        public char character3;
        public char character4;

        public override string ToString()
        {
            return String.Format("{0}{1}{2}{3}", character1, character2, character3, character4);
        }
    }
}