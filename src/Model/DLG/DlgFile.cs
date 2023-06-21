// https://gibberlings3.github.io/iesdp/file_formats/ie_formats/dlg_v1.htm#formDLGV1_TransTrigger

using System;
using System.Collections.Generic;

namespace TlkToSql.Model
{
    [Serializable]
    public class DlgFile
    {
        public string CharacterName;
        public List<StateEntry> States = new List<StateEntry>();
    }
}