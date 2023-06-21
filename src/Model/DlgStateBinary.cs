/* DLG V1 State table (actor responses) https://gibberlings3.github.io/iesdp/file_formats/ie_formats/dlg_v1.htm#formDLGV1_State
 * 
 * Offset	Size (data type)	Description
 * 0x0000	4 (strref)	Actor response text (i.e. what the non-player character says to the party)
 * 0x0004	4 (dword)	Index of the first transition corresponding to this state (i.e. the index in the transition table of the first potential response the party can make in this state).
 * 0x0008	4 (dword)	Number of transitions corresponding to this state (i.e. how many possible responses are there to this state). A consecutive range of transitions in the transition table are assigned to this state, starting from 'first', as given by the previous field, ranging up to (but not including) 'first'+'count'.
 * 0x000c	4 (dword)	Trigger for this state (as index into the state trigger table), or 0xFFFFFFFF if no trigger is used for this state.
 * 
 * */

using System;
using System.Runtime.InteropServices;

namespace TlkToSql.Model
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct DlgStateBinary
    {

        public Int32 actor;                     // Actor response text (i.e. what the non-player character says to the party)
        public Int32 name;                      // Index of the first transition corresponding to this state (i.e. the index in the transition table of the first potential response the party can make in this state).
        public Int32 number_of_transisiton;     // Number of transitions corresponding to this state (i.e. how many possible responses are there to this state). A consecutive range of transitions in the transition table are assigned to this state, starting from 'first', as given by the previous field, ranging up to (but not including) 'first'+'count'.
        public Int32 trigger;                   // Trigger for this state (as index into the state trigger table), or 0xFFFFFFFF if no trigger is used for this state.
    }
}