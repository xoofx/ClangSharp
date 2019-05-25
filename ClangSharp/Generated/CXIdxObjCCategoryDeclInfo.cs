using System;

namespace ClangSharp
{
    internal partial struct CXIdxObjCCategoryDeclInfo
    {
        public IntPtr containerInfo;
        public IntPtr objcClass;
        public CXCursor classCursor;
        public CXIdxLoc classLoc;
        public IntPtr protocols;
    }
}
