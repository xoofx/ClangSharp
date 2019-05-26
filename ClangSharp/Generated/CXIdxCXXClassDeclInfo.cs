#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal partial struct CXIdxCXXClassDeclInfo
    {
        public IntPtr declInfo;
        public IntPtr bases;
        public uint numBases;
    }
}
