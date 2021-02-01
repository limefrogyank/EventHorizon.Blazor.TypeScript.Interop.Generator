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

    public interface WebGLShaderPrecisionFormat : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<WebGLShaderPrecisionFormatCachedEntity>))]
    public class WebGLShaderPrecisionFormatCachedEntity : CachedEntityObject, WebGLShaderPrecisionFormat
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
        
        public decimal precision
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "precision"
                );
            }
        }

        
        public decimal rangeMax
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rangeMax"
                );
            }
        }

        
        public decimal rangeMin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rangeMin"
                );
            }
        }
        #endregion
        
        #region Constructor
        public WebGLShaderPrecisionFormatCachedEntity() : base() { }

        public WebGLShaderPrecisionFormatCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}