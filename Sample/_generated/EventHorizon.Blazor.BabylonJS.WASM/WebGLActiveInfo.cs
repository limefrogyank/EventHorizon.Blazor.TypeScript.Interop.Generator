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

    public interface WebGLActiveInfo : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<WebGLActiveInfoCachedEntity>))]
    public class WebGLActiveInfoCachedEntity : CachedEntityObject, WebGLActiveInfo
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
        }

        
        public decimal size
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
            }
        }

        
        public decimal type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "type"
                );
            }
        }
        #endregion
        
        #region Constructor
        public WebGLActiveInfoCachedEntity() : base() { }

        public WebGLActiveInfoCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}