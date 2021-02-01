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

    public interface DOMImplementation : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<DOMImplementationCachedEntity>))]
    public class DOMImplementationCachedEntity : CachedEntityObject, DOMImplementation
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
        public DOMImplementationCachedEntity() : base() { }

        public DOMImplementationCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public XMLDocumentCachedEntity createDocument(string namespace = null, string qualifiedName = null, DocumentType doctype = null)
        {
            return EventHorizonBlazorInterop.FuncClass<XMLDocumentCachedEntity>(
                entity => new XMLDocumentCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDocument" }, namespace, qualifiedName, doctype
                }
            );
        }

        public DocumentTypeCachedEntity createDocumentType(string qualifiedName, string publicId, string systemId)
        {
            return EventHorizonBlazorInterop.FuncClass<DocumentTypeCachedEntity>(
                entity => new DocumentTypeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDocumentType" }, qualifiedName, publicId, systemId
                }
            );
        }

        public DocumentCachedEntity createHTMLDocument(string title = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DocumentCachedEntity>(
                entity => new DocumentCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createHTMLDocument" }, title
                }
            );
        }

        public CachedEntity hasFeature(CachedEntity[] args)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "hasFeature" }, args
                }
            );
        }
        #endregion
    }
}