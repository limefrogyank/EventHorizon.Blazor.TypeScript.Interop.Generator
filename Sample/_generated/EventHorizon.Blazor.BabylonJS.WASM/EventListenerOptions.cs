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

    public interface EventListenerOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<EventListenerOptionsCachedEntity>))]
    public class EventListenerOptionsCachedEntity : CachedEntityObject, EventListenerOptions
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
        
        public bool capture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "capture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "capture",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public EventListenerOptionsCachedEntity() : base() { }

        public EventListenerOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}