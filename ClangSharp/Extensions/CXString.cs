﻿using System;

namespace ClangSharp
{
    internal partial struct CXString : IDisposable
    {
        public string CString => clang.getCString(this);

        public void Dispose() => clang.disposeString(this);

        public override string ToString() => CString;
    }
}
