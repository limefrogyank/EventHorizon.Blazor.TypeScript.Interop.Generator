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

    public interface NonDocumentTypeChildNode : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<NonDocumentTypeChildNodeCachedEntity>))]
    public class NonDocumentTypeChildNodeCachedEntity : CachedEntityObject, NonDocumentTypeChildNode
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
        private ElementCachedEntity __nextElementSibling;
        public ElementCachedEntity nextElementSibling
        {
            get
            {
            if(__nextElementSibling == null)
            {
                __nextElementSibling = EventHorizonBlazorInterop.GetClass<ElementCachedEntity>(
                    this.___guid,
                    "nextElementSibling",
                    (entity) =>
                    {
                        return new ElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __nextElementSibling;
            }
        }

        private ElementCachedEntity __previousElementSibling;
        public ElementCachedEntity previousElementSibling
        {
            get
            {
            if(__previousElementSibling == null)
            {
                __previousElementSibling = EventHorizonBlazorInterop.GetClass<ElementCachedEntity>(
                    this.___guid,
                    "previousElementSibling",
                    (entity) =>
                    {
                        return new ElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __previousElementSibling;
            }
        }
        #endregion
        
        #region Constructor
        public NonDocumentTypeChildNodeCachedEntity() : base() { }

        public NonDocumentTypeChildNodeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}