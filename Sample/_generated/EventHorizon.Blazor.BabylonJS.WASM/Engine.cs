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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Engine>))]
    public class Engine : CachedEntityObject
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
        public Engine() : base() { }

        public Engine(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Engine(
            HTMLCanvasElement canvasOrContext, System.Nullable<bool> antialias = null, EngineOptions options = null, System.Nullable<bool> adaptToDeviceRatio = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "", "Engine" },
                canvasOrContext, antialias, options, adaptToDeviceRatio
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}