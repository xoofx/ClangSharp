using System.Runtime.InteropServices;

namespace ClangSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate CXChildVisitResult CXCursorVisitor(CXCursor cursor, CXCursor parent, CXClientData client_data);
}
