using System;

namespace ClangSharp
{
    internal partial struct CXPlatformAvailability : IDisposable
    {
        public void Dispose() => clang.disposeCXPlatformAvailability(ref this);
    }
}
