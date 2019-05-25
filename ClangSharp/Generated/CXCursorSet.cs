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
