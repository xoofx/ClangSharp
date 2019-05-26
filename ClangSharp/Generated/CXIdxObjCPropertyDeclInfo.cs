#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal partial struct CXIdxObjCPropertyDeclInfo
    {
        public IntPtr declInfo;
        public IntPtr getter;
        public IntPtr setter;
    }
}
