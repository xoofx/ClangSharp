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
