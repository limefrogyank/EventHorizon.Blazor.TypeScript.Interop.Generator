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

    public interface WebGLTexture : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<WebGLTextureCachedEntity>))]
    public class WebGLTextureCachedEntity : CachedEntityObject, WebGLObject, WebGLTexture
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
        public WebGLTextureCachedEntity() : base() { }

        public WebGLTextureCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}