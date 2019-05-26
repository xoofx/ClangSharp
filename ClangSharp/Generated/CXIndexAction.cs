#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal  partial struct CXIndexAction
    {
        public CXIndexAction(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
