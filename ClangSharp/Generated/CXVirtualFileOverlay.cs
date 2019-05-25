using System;

namespace ClangSharp
{
    internal  partial struct CXVirtualFileOverlay
    {
        public CXVirtualFileOverlay(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
