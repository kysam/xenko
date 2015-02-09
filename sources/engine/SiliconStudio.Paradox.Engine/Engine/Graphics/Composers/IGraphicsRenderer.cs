﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

namespace SiliconStudio.Paradox.Engine.Graphics.Composers
{
    /// <summary>
    /// A graphics renderer.
    /// </summary>
    public interface IGraphicsRenderer
    {
        void Render(GraphicsRendererContext context);
    }
}