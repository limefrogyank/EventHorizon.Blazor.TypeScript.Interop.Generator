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

    public interface Event : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<EventCachedEntity>))]
    public class EventCachedEntity : CachedEntityObject, Event
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
        
        public bool bubbles
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "bubbles"
                );
            }
        }

        
        public bool cancelBubble
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cancelBubble"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cancelBubble",
                    value
                );
            }
        }

        
        public bool cancelable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cancelable"
                );
            }
        }

        
        public bool composed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "composed"
                );
            }
        }

        private EventTargetCachedEntity __currentTarget;
        public EventTargetCachedEntity currentTarget
        {
            get
            {
            if(__currentTarget == null)
            {
                __currentTarget = EventHorizonBlazorInterop.GetClass<EventTargetCachedEntity>(
                    this.___guid,
                    "currentTarget",
                    (entity) =>
                    {
                        return new EventTargetCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentTarget;
            }
        }

        
        public bool defaultPrevented
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "defaultPrevented"
                );
            }
        }

        
        public decimal eventPhase
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "eventPhase"
                );
            }
        }

        
        public bool isTrusted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isTrusted"
                );
            }
        }

        
        public bool returnValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "returnValue"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "returnValue",
                    value
                );
            }
        }

        private EventTargetCachedEntity __srcElement;
        public EventTargetCachedEntity srcElement
        {
            get
            {
            if(__srcElement == null)
            {
                __srcElement = EventHorizonBlazorInterop.GetClass<EventTargetCachedEntity>(
                    this.___guid,
                    "srcElement",
                    (entity) =>
                    {
                        return new EventTargetCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __srcElement;
            }
        }

        private EventTargetCachedEntity __target;
        public EventTargetCachedEntity target
        {
            get
            {
            if(__target == null)
            {
                __target = EventHorizonBlazorInterop.GetClass<EventTargetCachedEntity>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new EventTargetCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __target;
            }
        }

        
        public decimal timeStamp
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeStamp"
                );
            }
        }

        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
        }

        
        public decimal AT_TARGET
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "AT_TARGET"
                );
            }
        }

        
        public decimal BUBBLING_PHASE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BUBBLING_PHASE"
                );
            }
        }

        
        public decimal CAPTURING_PHASE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CAPTURING_PHASE"
                );
            }
        }

        
        public decimal NONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NONE"
                );
            }
        }
        #endregion
        
        #region Constructor
        public EventCachedEntity() : base() { }

        public EventCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public EventTargetCachedEntity[] composedPath()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<EventTargetCachedEntity>(
                entity => new EventTargetCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "composedPath" }
                }
            );
        }

        public void initEvent(string type, System.Nullable<bool> bubbles = null, System.Nullable<bool> cancelable = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initEvent" }, type, bubbles, cancelable
                }
            );
        }

        public void preventDefault()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preventDefault" }
                }
            );
        }

        public void stopImmediatePropagation()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stopImmediatePropagation" }
                }
            );
        }

        public void stopPropagation()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stopPropagation" }
                }
            );
        }
        #endregion
    }
}