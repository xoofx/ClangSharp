#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal  partial struct CXTranslationUnit
    {
        public CXTranslationUnit(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
