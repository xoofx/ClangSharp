using System;

namespace ClangSharp
{
    internal  partial struct CXModuleMapDescriptor
    {
        public CXModuleMapDescriptor(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
