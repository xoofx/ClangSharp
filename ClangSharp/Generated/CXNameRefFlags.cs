#pragma warning disable 659, 649
namespace ClangSharp
{
    internal enum CXNameRefFlags
    {
        CXNameRange_WantQualifier = 0x1,
        CXNameRange_WantTemplateArgs = 0x2,
        CXNameRange_WantSinglePiece = 0x4,
    }
}
