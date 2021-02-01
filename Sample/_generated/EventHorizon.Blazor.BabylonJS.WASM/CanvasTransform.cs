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

    public interface CanvasTransform : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasTransformCachedEntity>))]
    public class CanvasTransformCachedEntity : CachedEntityObject, CanvasTransform
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
        public CanvasTransformCachedEntity() : base() { }

        public CanvasTransformCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public DOMMatrixCachedEntity getTransform()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransform" }
                }
            );
        }

        public void resetTransform()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetTransform" }
                }
            );
        }

        public void rotate(decimal angle)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, angle
                }
            );
        }

        public void scale(decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scale" }, x, y
                }
            );
        }

        public void setTransform(decimal a, decimal b, decimal c, decimal d, decimal e, decimal f)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTransform" }, a, b, c, d, e, f
                }
            );
        }

        public void transform(decimal a, decimal b, decimal c, decimal d, decimal e, decimal f)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "transform" }, a, b, c, d, e, f
                }
            );
        }

        public void translate(decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "translate" }, x, y
                }
            );
        }
        #endregion
    }
}