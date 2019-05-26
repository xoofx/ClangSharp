#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal partial struct CXComment
    {
        public IntPtr ASTNode;
        public CXTranslationUnit TranslationUnit;
    }
}
