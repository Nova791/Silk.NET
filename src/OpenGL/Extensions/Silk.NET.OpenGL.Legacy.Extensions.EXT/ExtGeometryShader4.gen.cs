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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_geometry_shader4")]
    public abstract unsafe partial class ExtGeometryShader4 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_geometry_shader4";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameteriEXT")]
        public abstract void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameteriEXT")]
        public abstract void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramParameterPName pname, [Flow(FlowDirection.In)] int value);

        public ExtGeometryShader4(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

