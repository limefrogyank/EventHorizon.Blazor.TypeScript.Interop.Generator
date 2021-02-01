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

    public interface HTMLFormControlsCollection : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<HTMLFormControlsCollectionCachedEntity>))]
    public class HTMLFormControlsCollectionCachedEntity : CachedEntityObject, HTMLCollectionBase, HTMLFormControlsCollection
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
        public HTMLFormControlsCollectionCachedEntity() : base() { }

        public HTMLFormControlsCollectionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public RadioNodeListCachedEntity namedItem(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<RadioNodeListCachedEntity>(
                entity => new RadioNodeListCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "namedItem" }, name
                }
            );
        }
        #endregion
    }
}