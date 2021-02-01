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

    public interface Attr : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<AttrCachedEntity>))]
    public class AttrCachedEntity : CachedEntityObject, Node, Attr
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
        
        public string localName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "localName"
                );
            }
        }

        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
        }

        
        public string namespaceURI
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "namespaceURI"
                );
            }
        }

        private DocumentCachedEntity __ownerDocument;
        public DocumentCachedEntity ownerDocument
        {
            get
            {
            if(__ownerDocument == null)
            {
                __ownerDocument = EventHorizonBlazorInterop.GetClass<DocumentCachedEntity>(
                    this.___guid,
                    "ownerDocument",
                    (entity) =>
                    {
                        return new DocumentCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __ownerDocument;
            }
        }

        private ElementCachedEntity __ownerElement;
        public ElementCachedEntity ownerElement
        {
            get
            {
            if(__ownerElement == null)
            {
                __ownerElement = EventHorizonBlazorInterop.GetClass<ElementCachedEntity>(
                    this.___guid,
                    "ownerElement",
                    (entity) =>
                    {
                        return new ElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __ownerElement;
            }
        }

        
        public string prefix
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "prefix"
                );
            }
        }

        
        public bool specified
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "specified"
                );
            }
        }

        
        public string value
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "value"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "value",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AttrCachedEntity() : base() { }

        public AttrCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}