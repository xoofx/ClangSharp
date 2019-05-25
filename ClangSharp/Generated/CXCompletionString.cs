using System;

namespace ClangSharp
{
    internal  partial struct CXCompletionString
    {
        public CXCompletionString(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
