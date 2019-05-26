#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal  partial struct CXIdxClientContainer
    {
        public CXIdxClientContainer(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
