using System;

namespace Silk.NET.Vulkan
{
    public unsafe delegate void* ReallocationFunction(
        void* pUserData,
        void* pOriginal,
        UIntPtr size,
        UIntPtr alignment,
        SystemAllocationScope allocationScope);
}