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

    public interface ImageData : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ImageDataCachedEntity>))]
    public class ImageDataCachedEntity : CachedEntityObject, ImageData
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
        private Uint8ClampedArray __data;
        public Uint8ClampedArray data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<Uint8ClampedArray>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new Uint8ClampedArray() { ___guid = entity.___guid };
                    }
                );
            }
            return __data;
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
        }
        #endregion
        
        #region Constructor
        public ImageDataCachedEntity() : base() { }

        public ImageDataCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}