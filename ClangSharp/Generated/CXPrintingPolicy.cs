#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal  partial struct CXPrintingPolicy
    {
        public CXPrintingPolicy(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
