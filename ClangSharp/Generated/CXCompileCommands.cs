#pragma warning disable 659, 649
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
