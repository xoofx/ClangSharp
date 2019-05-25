using System;

namespace ClangSharp
{
    internal partial struct CXTUResourceUsage
    {
        public IntPtr data;
        public uint numEntries;
        public IntPtr entries;
    }
}
