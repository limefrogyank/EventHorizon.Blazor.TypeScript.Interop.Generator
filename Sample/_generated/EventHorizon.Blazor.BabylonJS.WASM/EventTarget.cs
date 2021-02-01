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

    public interface EventTarget : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<EventTargetCachedEntity>))]
    public class EventTargetCachedEntity : CachedEntityObject, EventTarget
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
        public EventTargetCachedEntity() : base() { }

        public EventTargetCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void addEventListener(string type, EventListener listener = null, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEventListener" }, type, listener, options
                }
            );
        }

        public bool dispatchEvent(Event @event)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "dispatchEvent" }, @event
                }
            );
        }

        public void removeEventListener(string type, EventListener callback = null, EventListenerOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeEventListener" }, type, callback, options
                }
            );
        }
        #endregion
    }
}