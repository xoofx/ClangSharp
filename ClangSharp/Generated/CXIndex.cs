#pragma warning disable 659, 649
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
