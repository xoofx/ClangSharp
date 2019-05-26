#pragma warning disable 659, 649
using System;

namespace ClangSharp
{
    internal partial struct IndexerCallbacks
    {
        public IntPtr abortQuery;
        public IntPtr diagnostic;
        public IntPtr enteredMainFile;
        public IntPtr ppIncludedFile;
        public IntPtr importedASTFile;
        public IntPtr startedTranslationUnit;
        public IntPtr indexDeclaration;
        public IntPtr indexEntityReference;
    }
}
