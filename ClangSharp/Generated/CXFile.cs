using System;

namespace ClangSharp
{
    internal  partial struct CXFile
    {
        public CXFile(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
