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

    public interface AnimationEvent : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationEventCachedEntity>))]
    public class AnimationEventCachedEntity : CachedEntityObject, Event, AnimationEvent
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
        
        public string animationName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "animationName"
                );
            }
        }

        
        public decimal elapsedTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "elapsedTime"
                );
            }
        }

        
        public string pseudoElement
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "pseudoElement"
                );
            }
        }
        #endregion
        
        #region Constructor
        public AnimationEventCachedEntity() : base() { }

        public AnimationEventCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}