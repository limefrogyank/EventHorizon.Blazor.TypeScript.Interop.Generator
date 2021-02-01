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

    public interface CanvasImageData : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasImageDataCachedEntity>))]
    public class CanvasImageDataCachedEntity : CachedEntityObject, CanvasImageData
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
        public CanvasImageDataCachedEntity() : base() { }

        public CanvasImageDataCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ImageDataCachedEntity createImageData(decimal sw, decimal sh)
        {
            return EventHorizonBlazorInterop.FuncClass<ImageDataCachedEntity>(
                entity => new ImageDataCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createImageData" }, sw, sh
                }
            );
        }

        public ImageDataCachedEntity getImageData(decimal sx, decimal sy, decimal sw, decimal sh)
        {
            return EventHorizonBlazorInterop.FuncClass<ImageDataCachedEntity>(
                entity => new ImageDataCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getImageData" }, sx, sy, sw, sh
                }
            );
        }

        public void putImageData(ImageData imagedata, decimal dx, decimal dy)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "putImageData" }, imagedata, dx, dy
                }
            );
        }
        #endregion
    }
}