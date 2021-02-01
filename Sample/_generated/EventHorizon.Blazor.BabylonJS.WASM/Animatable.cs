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

    public interface Animatable : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<AnimatableCachedEntity>))]
    public class AnimatableCachedEntity : CachedEntityObject, Animatable
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
        public AnimatableCachedEntity() : base() { }

        public AnimatableCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public AnimationCachedEntity animate(Keyframe[] keyframes = null, System.Nullable<decimal> options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationCachedEntity>(
                entity => new AnimationCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "animate" }, keyframes, options
                }
            );
        }

        public AnimationCachedEntity[] getAnimations()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationCachedEntity>(
                entity => new AnimationCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimations" }
                }
            );
        }
        #endregion
    }
}