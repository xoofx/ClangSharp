using System;

namespace ClangSharp
{
    internal  partial struct CXRemapping
    {
        public CXRemapping(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
