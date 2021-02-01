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

    public interface CanvasGradient : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasGradientCachedEntity>))]
    public class CanvasGradientCachedEntity : CachedEntityObject, CanvasGradient
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
        public CanvasGradientCachedEntity() : base() { }

        public CanvasGradientCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void addColorStop(decimal offset, string color)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addColorStop" }, offset, color
                }
            );
        }
        #endregion
    }
}