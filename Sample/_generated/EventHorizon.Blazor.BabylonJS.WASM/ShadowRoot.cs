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

    public interface ShadowRoot : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ShadowRootCachedEntity>))]
    public class ShadowRootCachedEntity : CachedEntityObject, DocumentFragment, DocumentOrShadowRoot, InnerHTML, ShadowRoot
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
        private ElementCachedEntity __host;
        public ElementCachedEntity host
        {
            get
            {
            if(__host == null)
            {
                __host = EventHorizonBlazorInterop.GetClass<ElementCachedEntity>(
                    this.___guid,
                    "host",
                    (entity) =>
                    {
                        return new ElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __host;
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
        }
        #endregion
        
        #region Constructor
        public ShadowRootCachedEntity() : base() { }

        public ShadowRootCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}