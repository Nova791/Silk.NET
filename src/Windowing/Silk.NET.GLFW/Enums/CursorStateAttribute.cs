﻿//
// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Attribute for setting <see cref="CursorModeValue"/> of the cursor.
    /// </summary>
    /// <seealso cref="IGLFW.SetInputMode(Window*,CursorStateAttribute,CursorModeValue)"/>
    /// <seealso cref="IGLFW.GetInputMode(Window*,CursorStateAttribute)"/>
    public enum CursorStateAttribute
    {
        /// <summary>
        /// Attribute for setting <see cref="CursorModeValue"/> of the cursor.
        /// </summary>
        Cursor = 0x00033001,
    }
}
