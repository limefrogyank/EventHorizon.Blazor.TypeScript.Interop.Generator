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

    public interface EXT_blend_minmax : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<EXT_blend_minmaxCachedEntity>))]
    public class EXT_blend_minmaxCachedEntity : CachedEntityObject, EXT_blend_minmax
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
        
        public decimal MAX_EXT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_EXT"
                );
            }
        }

        
        public decimal MIN_EXT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MIN_EXT"
                );
            }
        }
        #endregion
        
        #region Constructor
        public EXT_blend_minmaxCachedEntity() : base() { }

        public EXT_blend_minmaxCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}