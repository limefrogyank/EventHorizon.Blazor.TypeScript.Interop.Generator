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

    public interface DOMRectList : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<DOMRectListCachedEntity>))]
    public class DOMRectListCachedEntity : CachedEntityObject, DOMRectList
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
        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
        }
        #endregion
        
        #region Constructor
        public DOMRectListCachedEntity() : base() { }

        public DOMRectListCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public DOMRectCachedEntity item(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMRectCachedEntity>(
                entity => new DOMRectCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "item" }, index
                }
            );
        }
        #endregion
    }
}