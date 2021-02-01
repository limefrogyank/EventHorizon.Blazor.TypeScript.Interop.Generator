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

    public interface Element : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ElementCachedEntity>))]
    public class ElementCachedEntity : CachedEntityObject, Node, Animatable, ChildNode, InnerHTML, NonDocumentTypeChildNode, ParentNode, Slottable, Element
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
        private HTMLSlotElementCachedEntity __assignedSlot;
        public HTMLSlotElementCachedEntity assignedSlot
        {
            get
            {
            if(__assignedSlot == null)
            {
                __assignedSlot = EventHorizonBlazorInterop.GetClass<HTMLSlotElementCachedEntity>(
                    this.___guid,
                    "assignedSlot",
                    (entity) =>
                    {
                        return new HTMLSlotElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __assignedSlot;
            }
        }

        private NamedNodeMapCachedEntity __attributes;
        public NamedNodeMapCachedEntity attributes
        {
            get
            {
            if(__attributes == null)
            {
                __attributes = EventHorizonBlazorInterop.GetClass<NamedNodeMapCachedEntity>(
                    this.___guid,
                    "attributes",
                    (entity) =>
                    {
                        return new NamedNodeMapCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __attributes;
            }
        }

        private DOMTokenListCachedEntity __classList;
        public DOMTokenListCachedEntity classList
        {
            get
            {
            if(__classList == null)
            {
                __classList = EventHorizonBlazorInterop.GetClass<DOMTokenListCachedEntity>(
                    this.___guid,
                    "classList",
                    (entity) =>
                    {
                        return new DOMTokenListCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __classList;
            }
        }

        
        public string className
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "className"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "className",
                    value
                );
            }
        }

        
        public decimal clientHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "clientHeight"
                );
            }
        }

        
        public decimal clientLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "clientLeft"
                );
            }
        }

        
        public decimal clientTop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "clientTop"
                );
            }
        }

        
        public decimal clientWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "clientWidth"
                );
            }
        }

        
        public string id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        
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

        
        public string outerHTML
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "outerHTML"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outerHTML",
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

        
        public decimal scrollHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollHeight"
                );
            }
        }

        
        public decimal scrollLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollLeft",
                    value
                );
            }
        }

        
        public decimal scrollTop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollTop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollTop",
                    value
                );
            }
        }

        
        public decimal scrollWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollWidth"
                );
            }
        }

        private ShadowRootCachedEntity __shadowRoot;
        public ShadowRootCachedEntity shadowRoot
        {
            get
            {
            if(__shadowRoot == null)
            {
                __shadowRoot = EventHorizonBlazorInterop.GetClass<ShadowRootCachedEntity>(
                    this.___guid,
                    "shadowRoot",
                    (entity) =>
                    {
                        return new ShadowRootCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __shadowRoot;
            }
        }

        
        public string slot
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "slot"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "slot",
                    value
                );
            }
        }

        
        public string tagName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "tagName"
                );
            }
        }
        #endregion
        
        #region Constructor
        public ElementCachedEntity() : base() { }

        public ElementCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        #region onfullscreenchange TODO: Get Comments as metadata identification
        private bool _isOnfullscreenchangeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onfullscreenchangeActionMap = new Dictionary<string, Func<Task>>();

        public string onfullscreenchange(
            Func<Task> callback
        )
        {
            SetupOnfullscreenchangeLoop();

            var handle = Guid.NewGuid().ToString();
            _onfullscreenchangeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onfullscreenchange_Remove(
            string handle
        )
        {
            return _onfullscreenchangeActionMap.Remove(
                handle
            );
        }

        private void SetupOnfullscreenchangeLoop()
        {
            if (_isOnfullscreenchangeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onfullscreenchange",
                "CallOnfullscreenchangeActions",
                _invokableReference
            );
            _isOnfullscreenchangeEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnfullscreenchangeActions()
        {
            foreach (var action in _onfullscreenchangeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onfullscreenerror TODO: Get Comments as metadata identification
        private bool _isOnfullscreenerrorEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onfullscreenerrorActionMap = new Dictionary<string, Func<Task>>();

        public string onfullscreenerror(
            Func<Task> callback
        )
        {
            SetupOnfullscreenerrorLoop();

            var handle = Guid.NewGuid().ToString();
            _onfullscreenerrorActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onfullscreenerror_Remove(
            string handle
        )
        {
            return _onfullscreenerrorActionMap.Remove(
                handle
            );
        }

        private void SetupOnfullscreenerrorLoop()
        {
            if (_isOnfullscreenerrorEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onfullscreenerror",
                "CallOnfullscreenerrorActions",
                _invokableReference
            );
            _isOnfullscreenerrorEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnfullscreenerrorActions()
        {
            foreach (var action in _onfullscreenerrorActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public ShadowRootCachedEntity attachShadow(ShadowRootInit init)
        {
            return EventHorizonBlazorInterop.FuncClass<ShadowRootCachedEntity>(
                entity => new ShadowRootCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "attachShadow" }, init
                }
            );
        }

        public K closest(K selector)
        {
            return EventHorizonBlazorInterop.FuncClass<K>(
                entity => new K() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "closest" }, selector
                }
            );
        }

        public string getAttribute(string qualifiedName)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getAttribute" }, qualifiedName
                }
            );
        }

        public string getAttributeNS(string localName, string namespace = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributeNS" }, namespace, localName
                }
            );
        }

        public string[] getAttributeNames()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributeNames" }
                }
            );
        }

        public AttrCachedEntity getAttributeNode(string qualifiedName)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAttributeNode" }, qualifiedName
                }
            );
        }

        public AttrCachedEntity getAttributeNodeNS(string localName, string namespace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAttributeNodeNS" }, namespace, localName
                }
            );
        }

        public DOMRectCachedEntity getBoundingClientRect()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMRectCachedEntity>(
                entity => new DOMRectCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBoundingClientRect" }
                }
            );
        }

        public DOMRectListCachedEntity getClientRects()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMRectListCachedEntity>(
                entity => new DOMRectListCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getClientRects" }
                }
            );
        }

        public HTMLCollectionOfCachedEntity<ElementCachedEntity> getElementsByClassName(string classNames)
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLCollectionOfCachedEntity<ElementCachedEntity>>(
                entity => new HTMLCollectionOfCachedEntity<ElementCachedEntity>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getElementsByClassName" }, classNames
                }
            );
        }

        public HTMLCollectionOfCachedEntity<K> getElementsByTagName(K qualifiedName)
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLCollectionOfCachedEntity<K>>(
                entity => new HTMLCollectionOfCachedEntity<K>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getElementsByTagName" }, qualifiedName
                }
            );
        }

        public HTMLCollectionOfCachedEntity<CachedEntity> getElementsByTagNameNS(object namespaceURI, string localName)
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLCollectionOfCachedEntity<CachedEntity>>(
                entity => new HTMLCollectionOfCachedEntity<CachedEntity>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getElementsByTagNameNS" }, namespaceURI, localName
                }
            );
        }

        public bool hasAttribute(string qualifiedName)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasAttribute" }, qualifiedName
                }
            );
        }

        public bool hasAttributeNS(string localName, string namespace = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasAttributeNS" }, namespace, localName
                }
            );
        }

        public bool hasAttributes()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasAttributes" }
                }
            );
        }

        public bool hasPointerCapture(decimal pointerId)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasPointerCapture" }, pointerId
                }
            );
        }

        public ElementCachedEntity insertAdjacentElement(CachedEntity position, Element insertedElement)
        {
            return EventHorizonBlazorInterop.FuncClass<ElementCachedEntity>(
                entity => new ElementCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "insertAdjacentElement" }, position, insertedElement
                }
            );
        }

        public void insertAdjacentHTML(CachedEntity where, string html)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "insertAdjacentHTML" }, where, html
                }
            );
        }

        public void insertAdjacentText(CachedEntity where, string text)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "insertAdjacentText" }, where, text
                }
            );
        }

        public bool matches(string selectors)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "matches" }, selectors
                }
            );
        }

        public CachedEntity msGetRegionContent()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "msGetRegionContent" }
                }
            );
        }

        public void releasePointerCapture(decimal pointerId)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "releasePointerCapture" }, pointerId
                }
            );
        }

        public void removeAttribute(string qualifiedName)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeAttribute" }, qualifiedName
                }
            );
        }

        public void removeAttributeNS(string localName, string namespace = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeAttributeNS" }, namespace, localName
                }
            );
        }

        public AttrCachedEntity removeAttributeNode(Attr attr)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAttributeNode" }, attr
                }
            );
        }

        public async ValueTask requestFullscreen(FullscreenOptions options = null)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "requestFullscreen" }, options
                }
            );
        }

        public void requestPointerLock()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "requestPointerLock" }
                }
            );
        }

        public void scroll(ScrollToOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scroll" }, options
                }
            );
        }

        public void scrollBy(ScrollToOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scrollBy" }, options
                }
            );
        }

        public void scrollIntoView(System.Nullable<bool> arg = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scrollIntoView" }, arg
                }
            );
        }

        public void scrollTo(ScrollToOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scrollTo" }, options
                }
            );
        }

        public void setAttribute(string qualifiedName, string value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAttribute" }, qualifiedName, value
                }
            );
        }

        public void setAttributeNS(string qualifiedName, string value, string namespace = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAttributeNS" }, namespace, qualifiedName, value
                }
            );
        }

        public AttrCachedEntity setAttributeNode(Attr attr)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAttributeNode" }, attr
                }
            );
        }

        public AttrCachedEntity setAttributeNodeNS(Attr attr)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAttributeNodeNS" }, attr
                }
            );
        }

        public void setPointerCapture(decimal pointerId)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPointerCapture" }, pointerId
                }
            );
        }

        public bool toggleAttribute(string qualifiedName, System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "toggleAttribute" }, qualifiedName, force
                }
            );
        }

        public bool webkitMatchesSelector(string selectors)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "webkitMatchesSelector" }, selectors
                }
            );
        }

        public void addEventListener(K type, ActionCallback<Element, K> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEventListener" }, type, listener, options
                }
            );
        }

        public void removeEventListener(K type, ActionCallback<Element, K> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeEventListener" }, type, listener, options
                }
            );
        }
        #endregion
    }
}