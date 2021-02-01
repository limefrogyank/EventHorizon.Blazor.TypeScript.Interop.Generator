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

    public interface ShadowRootInit : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ShadowRootInitCachedEntity>))]
    public class ShadowRootInitCachedEntity : CachedEntityObject, ShadowRootInit
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
        
        public bool delegatesFocus
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "delegatesFocus"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delegatesFocus",
                    value
                );
            }
        }

        
        public CachedEntity mode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "mode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mode",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ShadowRootInitCachedEntity() : base() { }

        public ShadowRootInitCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}