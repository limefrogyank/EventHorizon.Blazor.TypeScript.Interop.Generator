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

    public interface FullscreenOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<FullscreenOptionsCachedEntity>))]
    public class FullscreenOptionsCachedEntity : CachedEntityObject, FullscreenOptions
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
        
        public CachedEntity navigationUI
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "navigationUI"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "navigationUI",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public FullscreenOptionsCachedEntity() : base() { }

        public FullscreenOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}