// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct ShaderModuleCreateInfo
    {
        public ShaderModuleCreateInfo
        (
            StructureType sType = StructureType.ShaderModuleCreateInfo,
            void* pNext = default,
            ShaderModuleCreateFlags flags = default,
            UIntPtr codeSize = default,
            uint* pCode = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           CodeSize = codeSize;
           PCode = pCode;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ShaderModuleCreateFlags Flags;
/// <summary></summary>
        public UIntPtr CodeSize;
/// <summary></summary>
        public uint* PCode;
    }
}
