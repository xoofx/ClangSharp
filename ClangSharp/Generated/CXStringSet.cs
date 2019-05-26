#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal partial struct CXStringSet
    {
        public IntPtr Strings;
        public uint Count;
    }
}
