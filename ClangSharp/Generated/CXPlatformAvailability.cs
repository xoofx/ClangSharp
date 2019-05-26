#pragma warning disable 659, 649
namespace ClangSharp
{
    internal partial struct CXPlatformAvailability
    {
        public CXString Platform;
        public CXVersion Introduced;
        public CXVersion Deprecated;
        public CXVersion Obsoleted;
        public int Unavailable;
        public CXString Message;
    }
}
