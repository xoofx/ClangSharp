﻿#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal partial struct CXEvalResult : IDisposable
    {
        public double AsDouble => clang.EvalResult_getAsDouble(this);

        public int AsInt => clang.EvalResult_getAsInt(this);

        public long AsLongLong => clang.EvalResult_getAsLongLong(this);

        public string AsStr => clang.EvalResult_getAsStr(this);

        public ulong AsUnsigned => clang.EvalResult_getAsUnsigned(this);

        public bool IsUnsignedInt => clang.EvalResult_isUnsignedInt(this) != 0;

        public CXEvalResultKind Kind => clang.EvalResult_getKind(this);

        public void Dispose() => clang.EvalResult_dispose(this);
    }
}
