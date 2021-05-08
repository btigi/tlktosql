using System;
using System.IO;
using System.Runtime.InteropServices;

namespace TlkToSql
{
    public class Common
    {
        public static object ReadStruct(BinaryReader br, Type t)
        {
            var buff = br.ReadBytes(Marshal.SizeOf(t));
            var handle = GCHandle.Alloc(buff, GCHandleType.Pinned);
            var s = (object)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), t);
            handle.Free();
            return s;
        }
    }
}