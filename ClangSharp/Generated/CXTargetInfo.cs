#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal  partial struct CXTargetInfo
    {
        public CXTargetInfo(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
