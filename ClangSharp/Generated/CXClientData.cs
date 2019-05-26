#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal  partial struct CXClientData
    {
        public CXClientData(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
