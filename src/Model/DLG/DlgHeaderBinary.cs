/* DLG V1 Header https://gibberlings3.github.io/iesdp/file_formats/ie_formats/dlg_v1.htm#formDLGV1_Header
 * 
 * Offset	Size (data type)	Description
 * 0x0000	4 (char array)	Signature ('DLG ')
 * 0x0004	4 (char array)	Version ('V1.0')
 * 0x0008	4 (dword)	Number of states
 * 0x000c	4 (dword)	Offset of state table from start of file
 * 0x0010	4 (dword)	Number of transitions
 * 0x0014	4 (dword)	Offset of transition table from start of file
 * 0x0018	4 (dword)	Offset of state trigger table from start of file
 * 0x001c	4 (dword)	Number of state triggers
 * 0x0020	4 (dword)	Offset of transition trigger table from start of file
 * 0x0024	4 (dword)	Number of transition triggers
 * 0x0028	4 (dword)	Offset of action table from start of file
 * 0x002c	4 (dword)	Number of actions
 * 0x0030	4 (dword)	Flags specifying what the creature does when the dialog is interrupted by a hostile action from a EA < GOODCUTOFF creature.
 * * Bit 0: Enemy()
 * * Bit 1: EscapeArea()
 * * Bit 2: nothing (but since the action was hostile, it behaves similar to bit 0)
 * * In addition, all these bits trigger the not-pause behaviour.
 * * Hostile action is something like an effect from a spell with the hostile flag, damage effect, a simple attack or a failed pickpocket action.
 * * Note: This field does not exist in DLG files used in BG1.
*/

using System;
using System.Runtime.InteropServices;

namespace TlkToSql.Model
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct DlgHeaderBinary
    {
                                                    // Order of variable is important
        public Array4 signature;                    // Signature ('DLG ')
        public Array4 version;                      // Version ('V1.0')
        public int StateCount;                      // Number of states
        public int StateOffset;                     // Offset of state table from start of file
        public int TransitionCount;                 // Number of transitions
        public int TransitionOffset;                // Offset of transition table from start of file
        public int TriggerStateOffset;              // Offset of state trigger table from start of file
        public int TriggerStateCount;               // Number of state triggers
        public int Offset_of_transition_trigger;    // Offset of transition trigger table from start of file
        public int Number_of_transition_triggers;   // Number of transition triggers
        public int Offset_of_action;                // Offset of action table from start of file
        public int Number_of_actions;               // Number of actions
        public int Flags;                           // Flags specifying what the creature does when the dialog is interrupted by a hostile action from a EA<GOODCUTOFF creature.
    }
}