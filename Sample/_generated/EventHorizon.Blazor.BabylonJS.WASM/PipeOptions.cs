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

    public interface PipeOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<PipeOptionsCachedEntity>))]
    public class PipeOptionsCachedEntity : CachedEntityObject, PipeOptions
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
        
        public bool preventAbort
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preventAbort"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preventAbort",
                    value
                );
            }
        }

        
        public bool preventCancel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preventCancel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preventCancel",
                    value
                );
            }
        }

        
        public bool preventClose
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preventClose"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preventClose",
                    value
                );
            }
        }

        private AbortSignalCachedEntity __signal;
        public AbortSignalCachedEntity signal
        {
            get
            {
            if(__signal == null)
            {
                __signal = EventHorizonBlazorInterop.GetClass<AbortSignalCachedEntity>(
                    this.___guid,
                    "signal",
                    (entity) =>
                    {
                        return new AbortSignalCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __signal;
            }
            set
            {
__signal = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "signal",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public PipeOptionsCachedEntity() : base() { }

        public PipeOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}