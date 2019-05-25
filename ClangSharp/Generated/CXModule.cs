using System;

namespace ClangSharp
{
    internal  partial struct CXModule
    {
        public CXModule(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
