using System.Runtime.InteropServices;

namespace ClangSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate CXVisitorResult CXFieldVisitor(CXCursor C, CXClientData client_data);
}
