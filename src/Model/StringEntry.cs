using System;

namespace TlkToSql.Model
{
    [Serializable]
    public class StringEntry
    {
        public string Text { get; set; }
        public StringEntryType Flags { get; set; }
        public string Sound { get; set; }
        public int VolumeVariance { get; set; }
        public int PitchVariance { get; set; }
        public int Strref { get; set; }
    }
}