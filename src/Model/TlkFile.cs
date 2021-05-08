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