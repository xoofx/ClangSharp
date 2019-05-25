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
