#pragma warning disable 659, 649
using System.Runtime.InteropServices;

namespace ClangSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CXInclusionVisitor(CXFile included_file, out CXSourceLocation inclusion_stack, uint include_len, CXClientData client_data);
}
