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

    public interface CanvasDrawImage : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasDrawImageCachedEntity>))]
    public class CanvasDrawImageCachedEntity : CachedEntityObject, CanvasDrawImage
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
        public CanvasDrawImageCachedEntity() : base() { }

        public CanvasDrawImageCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void drawImage(HTMLOrSVGImageElement image, decimal dx, decimal dy)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawImage" }, image, dx, dy
                }
            );
        }
        #endregion
    }
}