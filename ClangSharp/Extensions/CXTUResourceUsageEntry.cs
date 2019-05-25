namespace ClangSharp
{
    internal partial struct CXTUResourceUsageEntry
    {
        public string Name => clang.getTUResourceUsageName(kind);
    }
}
