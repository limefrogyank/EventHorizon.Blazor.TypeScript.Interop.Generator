/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    public interface WebGLFramebuffer : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<WebGLFramebufferCachedEntity>))]
    public class WebGLFramebufferCachedEntity : CachedEntityObject, WebGLObject, WebGLFramebuffer
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public WebGLFramebufferCachedEntity() : base() { }

        public WebGLFramebufferCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}