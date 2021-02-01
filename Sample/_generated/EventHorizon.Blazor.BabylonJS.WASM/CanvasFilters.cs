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

    public interface CanvasFilters : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasFiltersCachedEntity>))]
    public class CanvasFiltersCachedEntity : CachedEntityObject, CanvasFilters
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
        
        public string filter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "filter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filter",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CanvasFiltersCachedEntity() : base() { }

        public CanvasFiltersCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}