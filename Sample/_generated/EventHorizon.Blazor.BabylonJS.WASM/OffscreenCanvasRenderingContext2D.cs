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

    public interface OffscreenCanvasRenderingContext2D : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<OffscreenCanvasRenderingContext2DCachedEntity>))]
    public class OffscreenCanvasRenderingContext2DCachedEntity : CachedEntityObject, CanvasCompositing, CanvasDrawImage, CanvasDrawPath, CanvasFillStrokeStyles, CanvasFilters, CanvasImageData, CanvasImageSmoothing, CanvasPath, CanvasPathDrawingStyles, CanvasRect, CanvasShadowStyles, CanvasState, CanvasText, CanvasTextDrawingStyles, CanvasTransform, OffscreenCanvasRenderingContext2D
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
        private OffscreenCanvasCachedEntity __canvas;
        public OffscreenCanvasCachedEntity canvas
        {
            get
            {
            if(__canvas == null)
            {
                __canvas = EventHorizonBlazorInterop.GetClass<OffscreenCanvasCachedEntity>(
                    this.___guid,
                    "canvas",
                    (entity) =>
                    {
                        return new OffscreenCanvasCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __canvas;
            }
        }
        #endregion
        
        #region Constructor
        public OffscreenCanvasRenderingContext2DCachedEntity() : base() { }

        public OffscreenCanvasRenderingContext2DCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void commit()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "commit" }
                }
            );
        }
        #endregion
    }
}