#pragma warning disable 659, 649
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
