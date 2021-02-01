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

    public interface HTMLCollection : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<HTMLCollectionCachedEntity>))]
    public class HTMLCollectionCachedEntity : CachedEntityObject, HTMLCollectionBase, HTMLCollection
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
        public HTMLCollectionCachedEntity() : base() { }

        public HTMLCollectionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ElementCachedEntity namedItem(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<ElementCachedEntity>(
                entity => new ElementCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "namedItem" }, name
                }
            );
        }
        #endregion
    }
}