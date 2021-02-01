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

    public interface AnimationTimeline : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationTimelineCachedEntity>))]
    public class AnimationTimelineCachedEntity : CachedEntityObject, AnimationTimeline
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
        
        public decimal currentTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentTime"
                );
            }
        }
        #endregion
        
        #region Constructor
        public AnimationTimelineCachedEntity() : base() { }

        public AnimationTimelineCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}