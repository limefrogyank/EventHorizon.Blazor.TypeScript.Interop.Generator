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

    public interface NonElementParentNode : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<NonElementParentNodeCachedEntity>))]
    public class NonElementParentNodeCachedEntity : CachedEntityObject, NonElementParentNode
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
        public NonElementParentNodeCachedEntity() : base() { }

        public NonElementParentNodeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ElementCachedEntity getElementById(string elementId)
        {
            return EventHorizonBlazorInterop.FuncClass<ElementCachedEntity>(
                entity => new ElementCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getElementById" }, elementId
                }
            );
        }
        #endregion
    }
}