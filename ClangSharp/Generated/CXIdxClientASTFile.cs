using System;

namespace ClangSharp
{
    internal  partial struct CXIdxClientASTFile
    {
        public CXIdxClientASTFile(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
