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

    public interface CanvasPattern : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasPatternCachedEntity>))]
    public class CanvasPatternCachedEntity : CachedEntityObject, CanvasPattern
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
        public CanvasPatternCachedEntity() : base() { }

        public CanvasPatternCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void setTransform(DOMMatrix2DInit transform = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTransform" }, transform
                }
            );
        }
        #endregion
    }
}