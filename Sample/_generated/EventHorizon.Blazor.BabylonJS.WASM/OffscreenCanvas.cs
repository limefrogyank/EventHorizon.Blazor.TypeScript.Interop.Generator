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

    public interface OffscreenCanvas : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<OffscreenCanvasCachedEntity>))]
    public class OffscreenCanvasCachedEntity : CachedEntityObject, EventTarget, OffscreenCanvas
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
        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public OffscreenCanvasCachedEntity() : base() { }

        public OffscreenCanvasCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ValueTask<BlobCachedEntity> convertToBlob(ImageEncodeOptions options = null)
        {
            return EventHorizonBlazorInterop.TaskClass<BlobCachedEntity>(
                entity => new BlobCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "convertToBlob" }, options
                }
            );
        }

        public OffscreenCanvasRenderingContext2DCachedEntity getContext(object contextId, CanvasRenderingContext2DSettings options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<OffscreenCanvasRenderingContext2DCachedEntity>(
                entity => new OffscreenCanvasRenderingContext2DCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getContext" }, contextId, options
                }
            );
        }

        public ImageBitmapCachedEntity transferToImageBitmap()
        {
            return EventHorizonBlazorInterop.FuncClass<ImageBitmapCachedEntity>(
                entity => new ImageBitmapCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transferToImageBitmap" }
                }
            );
        }
        #endregion
    }
}