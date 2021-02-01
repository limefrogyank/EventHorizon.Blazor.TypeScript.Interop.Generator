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

    public interface CanvasRenderingContext2DSettings : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasRenderingContext2DSettingsCachedEntity>))]
    public class CanvasRenderingContext2DSettingsCachedEntity : CachedEntityObject, CanvasRenderingContext2DSettings
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
        
        public bool alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
        public bool desynchronized
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "desynchronized"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "desynchronized",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CanvasRenderingContext2DSettingsCachedEntity() : base() { }

        public CanvasRenderingContext2DSettingsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}