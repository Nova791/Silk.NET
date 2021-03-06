// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_query_matrix")]
    public abstract unsafe partial class OesQueryMatrix : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_query_matrix";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mantissa">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        /// <param name="exponent">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glQueryMatrixxOES")]
        public abstract unsafe uint QueryMatrixx([Count(Count = 16), Flow(FlowDirection.Out)] int* mantissa, [Count(Count = 16), Flow(FlowDirection.Out)] int* exponent);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mantissa">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        /// <param name="exponent">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glQueryMatrixxOES")]
        public abstract uint QueryMatrixx([Count(Count = 16), Flow(FlowDirection.Out)] Span<int> mantissa, [Count(Count = 16), Flow(FlowDirection.Out)] Span<int> exponent);

        public OesQueryMatrix(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

