#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal partial struct CXString
    {
        public IntPtr data;
        public uint private_flags;
    }
}
