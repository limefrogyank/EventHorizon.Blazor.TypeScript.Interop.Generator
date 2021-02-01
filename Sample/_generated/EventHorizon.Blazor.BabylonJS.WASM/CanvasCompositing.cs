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

    public interface CanvasCompositing : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasCompositingCachedEntity>))]
    public class CanvasCompositingCachedEntity : CachedEntityObject, CanvasCompositing
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
        
        public decimal globalAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "globalAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "globalAlpha",
                    value
                );
            }
        }

        
        public string globalCompositeOperation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "globalCompositeOperation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "globalCompositeOperation",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CanvasCompositingCachedEntity() : base() { }

        public CanvasCompositingCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}