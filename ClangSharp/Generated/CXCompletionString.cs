#pragma warning disable 659, 649
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
