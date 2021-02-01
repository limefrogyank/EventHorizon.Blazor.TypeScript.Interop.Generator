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

    public interface CanvasDrawPath : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasDrawPathCachedEntity>))]
    public class CanvasDrawPathCachedEntity : CachedEntityObject, CanvasDrawPath
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
        public CanvasDrawPathCachedEntity() : base() { }

        public CanvasDrawPathCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void beginPath()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "beginPath" }
                }
            );
        }

        public void clip(CachedEntity fillRule = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clip" }, fillRule
                }
            );
        }

        public void fill(CachedEntity fillRule = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fill" }, fillRule
                }
            );
        }

        public bool isPointInPath(decimal x, decimal y, CachedEntity fillRule = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isPointInPath" }, x, y, fillRule
                }
            );
        }

        public bool isPointInStroke(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isPointInStroke" }, x, y
                }
            );
        }

        public void stroke()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stroke" }
                }
            );
        }
        #endregion
    }
}