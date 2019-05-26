#pragma warning disable 659, 649
using System.Runtime.InteropServices;

namespace ClangSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate CXVisitorResult CXFieldVisitor(CXCursor C, CXClientData client_data);
}
