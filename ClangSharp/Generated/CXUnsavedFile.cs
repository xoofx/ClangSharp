using System.Runtime.InteropServices;

namespace ClangSharp
{
    internal partial struct CXUnsavedFile
    {
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(StringMarshaler))] public string Filename;
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(StringMarshaler))] public string Contents;
        public uint Length;
    }
}
