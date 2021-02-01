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

    public interface HTMLCollectionOf<T> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<HTMLCollectionOfCachedEntity<CachedEntity>>))]
    public class HTMLCollectionOfCachedEntity<T> : CachedEntityObject, HTMLCollectionBase, HTMLCollectionOf<T> where T : CachedEntity, new()
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
        public HTMLCollectionOfCachedEntity() : base() { }

        public HTMLCollectionOfCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public T item(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "item" }, index
                }
            );
        }

        public T namedItem(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "namedItem" }, name
                }
            );
        }
        #endregion
    }
}