using System;

namespace ClangSharp
{
    internal  partial struct CXCompilationDatabase
    {
        public CXCompilationDatabase(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
