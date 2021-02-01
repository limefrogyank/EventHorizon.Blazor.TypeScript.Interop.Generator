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

    public interface CanvasRect : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasRectCachedEntity>))]
    public class CanvasRectCachedEntity : CachedEntityObject, CanvasRect
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
        public CanvasRectCachedEntity() : base() { }

        public CanvasRectCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void clearRect(decimal x, decimal y, decimal w, decimal h)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearRect" }, x, y, w, h
                }
            );
        }

        public void fillRect(decimal x, decimal y, decimal w, decimal h)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fillRect" }, x, y, w, h
                }
            );
        }

        public void strokeRect(decimal x, decimal y, decimal w, decimal h)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "strokeRect" }, x, y, w, h
                }
            );
        }
        #endregion
    }
}