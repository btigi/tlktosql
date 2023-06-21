using System.Runtime.InteropServices;

namespace TlkToSql.Model
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct TlkHeaderBinary
    {
        public Array4 ftype;
        public Array4 fversion;
        public short LanguageId;
        public int StringCount;
        public int StringOffset;
    }
}