#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal  partial struct CXIdxClientFile
    {
        public CXIdxClientFile(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
