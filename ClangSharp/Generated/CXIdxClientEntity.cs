using System;

namespace ClangSharp
{
    internal  partial struct CXIdxClientEntity
    {
        public CXIdxClientEntity(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
