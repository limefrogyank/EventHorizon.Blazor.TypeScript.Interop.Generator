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

    public interface HTMLAllCollection : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<HTMLAllCollectionCachedEntity>))]
    public class HTMLAllCollectionCachedEntity : CachedEntityObject, HTMLAllCollection
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
        public HTMLAllCollectionCachedEntity() : base() { }

        public HTMLAllCollectionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public HTMLCollectionCachedEntity item(string nameOrIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLCollectionCachedEntity>(
                entity => new HTMLCollectionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "item" }, nameOrIndex
                }
            );
        }

        public HTMLCollectionCachedEntity namedItem(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLCollectionCachedEntity>(
                entity => new HTMLCollectionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "namedItem" }, name
                }
            );
        }
        #endregion
    }
}