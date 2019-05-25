using System;

namespace ClangSharp
{
    internal  partial struct CXCompileCommands
    {
        public CXCompileCommands(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
