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

    public interface CanvasImageSmoothing : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasImageSmoothingCachedEntity>))]
    public class CanvasImageSmoothingCachedEntity : CachedEntityObject, CanvasImageSmoothing
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
        
        public bool imageSmoothingEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "imageSmoothingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageSmoothingEnabled",
                    value
                );
            }
        }

        
        public CachedEntity imageSmoothingQuality
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "imageSmoothingQuality"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageSmoothingQuality",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CanvasImageSmoothingCachedEntity() : base() { }

        public CanvasImageSmoothingCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}