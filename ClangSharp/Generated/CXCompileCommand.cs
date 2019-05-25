using System;

namespace ClangSharp
{
    internal  partial struct CXCompileCommand
    {
        public CXCompileCommand(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
