using System;

namespace ClangSharp
{
    internal partial struct CXIdxObjCProtocolRefInfo
    {
        public IntPtr protocol;
        public CXCursor cursor;
        public CXIdxLoc loc;
    }
}
