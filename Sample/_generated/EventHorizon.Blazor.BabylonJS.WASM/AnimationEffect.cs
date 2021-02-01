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

    public interface AnimationEffect : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationEffectCachedEntity>))]
    public class AnimationEffectCachedEntity : CachedEntityObject, AnimationEffect
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
        public AnimationEffectCachedEntity() : base() { }

        public AnimationEffectCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ComputedEffectTimingCachedEntity getComputedTiming()
        {
            return EventHorizonBlazorInterop.FuncClass<ComputedEffectTimingCachedEntity>(
                entity => new ComputedEffectTimingCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getComputedTiming" }
                }
            );
        }

        public EffectTimingCachedEntity getTiming()
        {
            return EventHorizonBlazorInterop.FuncClass<EffectTimingCachedEntity>(
                entity => new EffectTimingCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTiming" }
                }
            );
        }

        public void updateTiming(OptionalEffectTiming timing = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTiming" }, timing
                }
            );
        }
        #endregion
    }
}