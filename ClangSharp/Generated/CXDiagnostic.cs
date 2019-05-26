#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal  partial struct CXDiagnostic
    {
        public CXDiagnostic(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
