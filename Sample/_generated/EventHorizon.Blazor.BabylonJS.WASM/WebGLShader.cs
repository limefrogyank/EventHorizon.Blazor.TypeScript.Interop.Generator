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

    public interface WebGLShader : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<WebGLShaderCachedEntity>))]
    public class WebGLShaderCachedEntity : CachedEntityObject, WebGLObject, WebGLShader
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
        public WebGLShaderCachedEntity() : base() { }

        public WebGLShaderCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}