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
