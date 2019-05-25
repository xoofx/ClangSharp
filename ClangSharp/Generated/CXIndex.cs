using System;

namespace ClangSharp
{
    internal  partial struct CXIndex
    {
        public CXIndex(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
