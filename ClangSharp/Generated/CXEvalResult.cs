#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal  partial struct CXEvalResult
    {
        public CXEvalResult(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
