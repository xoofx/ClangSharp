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
