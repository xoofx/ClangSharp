#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal partial struct CXSourceRangeList
    {
        public uint count;
        public IntPtr ranges;
    }
}
