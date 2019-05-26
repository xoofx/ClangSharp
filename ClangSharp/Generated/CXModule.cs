#pragma warning disable 659, 649
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
