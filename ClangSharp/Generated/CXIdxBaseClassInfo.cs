#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal partial struct CXIdxBaseClassInfo
    {
        public IntPtr @base;
        public CXCursor cursor;
        public CXIdxLoc loc;
    }
}
