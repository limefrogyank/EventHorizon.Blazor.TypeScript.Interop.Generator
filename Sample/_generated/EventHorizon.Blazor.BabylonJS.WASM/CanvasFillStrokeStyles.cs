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

    public interface CanvasFillStrokeStyles : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasFillStrokeStylesCachedEntity>))]
    public class CanvasFillStrokeStylesCachedEntity : CachedEntityObject, CanvasFillStrokeStyles
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
        
        public string fillStyle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fillStyle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fillStyle",
                    value
                );
            }
        }

        
        public string strokeStyle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "strokeStyle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "strokeStyle",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CanvasFillStrokeStylesCachedEntity() : base() { }

        public CanvasFillStrokeStylesCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public CanvasGradientCachedEntity createLinearGradient(decimal x0, decimal y0, decimal x1, decimal y1)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasGradientCachedEntity>(
                entity => new CanvasGradientCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createLinearGradient" }, x0, y0, x1, y1
                }
            );
        }

        public CanvasPatternCachedEntity createPattern(HTMLOrSVGImageElement image, string repetition = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasPatternCachedEntity>(
                entity => new CanvasPatternCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createPattern" }, image, repetition
                }
            );
        }

        public CanvasGradientCachedEntity createRadialGradient(decimal x0, decimal y0, decimal r0, decimal x1, decimal y1, decimal r1)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasGradientCachedEntity>(
                entity => new CanvasGradientCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createRadialGradient" }, x0, y0, r0, x1, y1, r1
                }
            );
        }
        #endregion
    }
}