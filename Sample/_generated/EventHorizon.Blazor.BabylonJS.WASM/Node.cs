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

    public interface Node : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<NodeCachedEntity>))]
    public class NodeCachedEntity : CachedEntityObject, EventTarget, Node
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
        
        public string baseURI
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "baseURI"
                );
            }
        }

        private NodeListOfCachedEntity<ChildNodeCachedEntity> __childNodes;
        public NodeListOfCachedEntity<ChildNodeCachedEntity> childNodes
        {
            get
            {
            if(__childNodes == null)
            {
                __childNodes = EventHorizonBlazorInterop.GetClass<NodeListOfCachedEntity<ChildNodeCachedEntity>>(
                    this.___guid,
                    "childNodes",
                    (entity) =>
                    {
                        return new NodeListOfCachedEntity<ChildNodeCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __childNodes;
            }
        }

        private ChildNodeCachedEntity __firstChild;
        public ChildNodeCachedEntity firstChild
        {
            get
            {
            if(__firstChild == null)
            {
                __firstChild = EventHorizonBlazorInterop.GetClass<ChildNodeCachedEntity>(
                    this.___guid,
                    "firstChild",
                    (entity) =>
                    {
                        return new ChildNodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __firstChild;
            }
        }

        
        public bool isConnected
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isConnected"
                );
            }
        }

        private ChildNodeCachedEntity __lastChild;
        public ChildNodeCachedEntity lastChild
        {
            get
            {
            if(__lastChild == null)
            {
                __lastChild = EventHorizonBlazorInterop.GetClass<ChildNodeCachedEntity>(
                    this.___guid,
                    "lastChild",
                    (entity) =>
                    {
                        return new ChildNodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __lastChild;
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

        private ChildNodeCachedEntity __nextSibling;
        public ChildNodeCachedEntity nextSibling
        {
            get
            {
            if(__nextSibling == null)
            {
                __nextSibling = EventHorizonBlazorInterop.GetClass<ChildNodeCachedEntity>(
                    this.___guid,
                    "nextSibling",
                    (entity) =>
                    {
                        return new ChildNodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __nextSibling;
            }
        }

        
        public string nodeName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "nodeName"
                );
            }
        }

        
        public decimal nodeType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "nodeType"
                );
            }
        }

        
        public string nodeValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "nodeValue"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nodeValue",
                    value
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

        
        public CachedEntity parentElement
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "parentElement"
                );
            }
        }

        private ParentNodeCachedEntity __parentNode;
        public ParentNodeCachedEntity parentNode
        {
            get
            {
            if(__parentNode == null)
            {
                __parentNode = EventHorizonBlazorInterop.GetClass<ParentNodeCachedEntity>(
                    this.___guid,
                    "parentNode",
                    (entity) =>
                    {
                        return new ParentNodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __parentNode;
            }
        }

        private ChildNodeCachedEntity __previousSibling;
        public ChildNodeCachedEntity previousSibling
        {
            get
            {
            if(__previousSibling == null)
            {
                __previousSibling = EventHorizonBlazorInterop.GetClass<ChildNodeCachedEntity>(
                    this.___guid,
                    "previousSibling",
                    (entity) =>
                    {
                        return new ChildNodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __previousSibling;
            }
        }

        
        public string textContent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "textContent"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textContent",
                    value
                );
            }
        }

        
        public decimal ATTRIBUTE_NODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ATTRIBUTE_NODE"
                );
            }
        }

        
        public decimal CDATA_SECTION_NODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CDATA_SECTION_NODE"
                );
            }
        }

        
        public decimal COMMENT_NODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMMENT_NODE"
                );
            }
        }

        
        public decimal DOCUMENT_FRAGMENT_NODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DOCUMENT_FRAGMENT_NODE"
                );
            }
        }

        
        public decimal DOCUMENT_NODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DOCUMENT_NODE"
                );
            }
        }

        
        public decimal DOCUMENT_POSITION_CONTAINED_BY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DOCUMENT_POSITION_CONTAINED_BY"
                );
            }
        }

        
        public decimal DOCUMENT_POSITION_CONTAINS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DOCUMENT_POSITION_CONTAINS"
                );
            }
        }

        
        public decimal DOCUMENT_POSITION_DISCONNECTED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DOCUMENT_POSITION_DISCONNECTED"
                );
            }
        }

        
        public decimal DOCUMENT_POSITION_FOLLOWING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DOCUMENT_POSITION_FOLLOWING"
                );
            }
        }

        
        public decimal DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC"
                );
            }
        }

        
        public decimal DOCUMENT_POSITION_PRECEDING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DOCUMENT_POSITION_PRECEDING"
                );
            }
        }

        
        public decimal DOCUMENT_TYPE_NODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DOCUMENT_TYPE_NODE"
                );
            }
        }

        
        public decimal ELEMENT_NODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ELEMENT_NODE"
                );
            }
        }

        
        public decimal ENTITY_NODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ENTITY_NODE"
                );
            }
        }

        
        public decimal ENTITY_REFERENCE_NODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ENTITY_REFERENCE_NODE"
                );
            }
        }

        
        public decimal NOTATION_NODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NOTATION_NODE"
                );
            }
        }

        
        public decimal PROCESSING_INSTRUCTION_NODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "PROCESSING_INSTRUCTION_NODE"
                );
            }
        }

        
        public decimal TEXT_NODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXT_NODE"
                );
            }
        }
        #endregion
        
        #region Constructor
        public NodeCachedEntity() : base() { }

        public NodeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public T appendChild(T newChild)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "appendChild" }, newChild
                }
            );
        }

        public NodeCachedEntity cloneNode(System.Nullable<bool> deep = null)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "cloneNode" }, deep
                }
            );
        }

        public decimal compareDocumentPosition(Node other)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "compareDocumentPosition" }, other
                }
            );
        }

        public bool contains(Node other = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "contains" }, other
                }
            );
        }

        public NodeCachedEntity getRootNode(GetRootNodeOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRootNode" }, options
                }
            );
        }

        public bool hasChildNodes()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasChildNodes" }
                }
            );
        }

        public T insertBefore(T newChild, Node refChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "insertBefore" }, newChild, refChild
                }
            );
        }

        public bool isDefaultNamespace(string namespace = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isDefaultNamespace" }, namespace
                }
            );
        }

        public bool isEqualNode(Node otherNode = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isEqualNode" }, otherNode
                }
            );
        }

        public bool isSameNode(Node otherNode = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isSameNode" }, otherNode
                }
            );
        }

        public string lookupNamespaceURI(string prefix = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "lookupNamespaceURI" }, prefix
                }
            );
        }

        public string lookupPrefix(string namespace = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "lookupPrefix" }, namespace
                }
            );
        }

        public void normalize()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public T removeChild(T oldChild)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeChild" }, oldChild
                }
            );
        }

        public T replaceChild(Node newChild, T oldChild)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "replaceChild" }, newChild, oldChild
                }
            );
        }
        #endregion
    }
}