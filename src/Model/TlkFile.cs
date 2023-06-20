//https://gibberlings3.github.io/iesdp/file_formats/ie_formats/tlk_v1.htm
using System;
using System.Collections.Generic;

namespace TlkToSql.Model
{
    [Serializable]
    public class TlkFile
    {
        public short LangugeId;
        public List<StringEntry> Strings = new List<StringEntry>();
    }
}