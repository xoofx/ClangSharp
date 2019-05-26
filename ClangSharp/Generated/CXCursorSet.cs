#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal  partial struct CXCursorSet
    {
        public CXCursorSet(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
