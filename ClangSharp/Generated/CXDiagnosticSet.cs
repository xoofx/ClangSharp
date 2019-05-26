#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal  partial struct CXDiagnosticSet
    {
        public CXDiagnosticSet(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
