#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal partial struct CXCodeCompleteResults
    {
        public IntPtr Results;
        public uint NumResults;
    }
}
