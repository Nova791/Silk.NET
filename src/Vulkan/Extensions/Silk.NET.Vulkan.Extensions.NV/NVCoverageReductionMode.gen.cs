// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_coverage_reduction_mode")]
    public abstract unsafe partial class NVCoverageReductionMode : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_coverage_reduction_mode";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV")]
        public abstract unsafe Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pCombinationCount, [Count(Computed = "pCombinationCount"), Flow(FlowDirection.Out)] FramebufferMixedSamplesCombinationNV* pCombinations);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV")]
        public abstract Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pCombinationCount, [Count(Computed = "pCombinationCount"), Flow(FlowDirection.Out)] out FramebufferMixedSamplesCombinationNV pCombinations);

        public NVCoverageReductionMode(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

