// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using SiliconStudio.Core;

namespace SiliconStudio.Paradox.Engine.Graphics.Composers
{
    /// <summary>
    /// A forward rendering mode.
    /// </summary>
    [DataContract("GraphicsRenderingModeForward")]
    [Display("Forward")]
    public class GraphicsRenderingModeForward : IGraphicsRenderingMode
    {
        public string GetMainModelEffect()
        {
            return "ParadoxBaseShader";
        }

        /// <summary>
        /// Gets or sets the effect mixin that will applied on top of the default Forward effect mixin.
        /// </summary>
        /// <value>The effect overrider.</value>
        /// <userdoc>
        /// The effect overrider allows to override a global effect used when rendering in forward mode. The overrider can
        /// provide an effect that will be 'mixin' after the forward effect, allowing to change the behavior of the default 
        /// forward effect.
        /// </userdoc>
        public IGraphicsEffectMixinProvider EffectMixin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="EffectMixin"/> overrides completely the default effect of the
        /// rendering mode.
        /// </summary>
        /// <value><c>true</c> if [effect mixin overrides]; otherwise, <c>false</c>.</value>
        public bool EffectMixinOverrides { get; set; }
    }
}