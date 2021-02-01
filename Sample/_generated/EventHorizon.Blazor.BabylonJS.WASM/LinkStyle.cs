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

    public interface LinkStyle : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<LinkStyleCachedEntity>))]
    public class LinkStyleCachedEntity : CachedEntityObject, LinkStyle
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
        private CSSStyleSheetCachedEntity __sheet;
        public CSSStyleSheetCachedEntity sheet
        {
            get
            {
            if(__sheet == null)
            {
                __sheet = EventHorizonBlazorInterop.GetClass<CSSStyleSheetCachedEntity>(
                    this.___guid,
                    "sheet",
                    (entity) =>
                    {
                        return new CSSStyleSheetCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __sheet;
            }
        }
        #endregion
        
        #region Constructor
        public LinkStyleCachedEntity() : base() { }

        public LinkStyleCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}