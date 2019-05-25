using System;

namespace ClangSharp
{
    internal partial struct CXCursor
    {
        public CXCursorKind kind;
        public int xdata;
        public IntPtr data0; public IntPtr data1; public IntPtr data2;
    }
}
