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

    public interface Document : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<DocumentCachedEntity>))]
    public class DocumentCachedEntity : CachedEntityObject, Node, DocumentAndElementEventHandlers, DocumentOrShadowRoot, GlobalEventHandlers, NonElementParentNode, ParentNode, XPathEvaluatorBase, Document
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
        
        public string URL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "URL"
                );
            }
        }

        
        public string alinkColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "alinkColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alinkColor",
                    value
                );
            }
        }

        private HTMLAllCollectionCachedEntity __all;
        public HTMLAllCollectionCachedEntity all
        {
            get
            {
            if(__all == null)
            {
                __all = EventHorizonBlazorInterop.GetClass<HTMLAllCollectionCachedEntity>(
                    this.___guid,
                    "all",
                    (entity) =>
                    {
                        return new HTMLAllCollectionCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __all;
            }
        }

        private HTMLCollectionOfCachedEntity<HTMLAnchorElementCachedEntity> __anchors;
        public HTMLCollectionOfCachedEntity<HTMLAnchorElementCachedEntity> anchors
        {
            get
            {
            if(__anchors == null)
            {
                __anchors = EventHorizonBlazorInterop.GetClass<HTMLCollectionOfCachedEntity<HTMLAnchorElementCachedEntity>>(
                    this.___guid,
                    "anchors",
                    (entity) =>
                    {
                        return new HTMLCollectionOfCachedEntity<HTMLAnchorElementCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __anchors;
            }
        }

        private HTMLCollectionOfCachedEntity<HTMLAppletElementCachedEntity> __applets;
        public HTMLCollectionOfCachedEntity<HTMLAppletElementCachedEntity> applets
        {
            get
            {
            if(__applets == null)
            {
                __applets = EventHorizonBlazorInterop.GetClass<HTMLCollectionOfCachedEntity<HTMLAppletElementCachedEntity>>(
                    this.___guid,
                    "applets",
                    (entity) =>
                    {
                        return new HTMLCollectionOfCachedEntity<HTMLAppletElementCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __applets;
            }
        }

        
        public string bgColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "bgColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bgColor",
                    value
                );
            }
        }

        
        public CachedEntity body
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "body"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "body",
                    value
                );
            }
        }

        
        public string characterSet
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "characterSet"
                );
            }
        }

        
        public string charset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "charset"
                );
            }
        }

        
        public string compatMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "compatMode"
                );
            }
        }

        
        public string contentType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "contentType"
                );
            }
        }

        
        public string cookie
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "cookie"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cookie",
                    value
                );
            }
        }

        
        public HTMLScriptElementCachedEntity currentScript
        {
            get
            {
            return EventHorizonBlazorInterop.Get<HTMLScriptElementCachedEntity>(
                    this.___guid,
                    "currentScript"
                );
            }
        }

        private globalThis __defaultView;
        public globalThis defaultView
        {
            get
            {
            if(__defaultView == null)
            {
                __defaultView = EventHorizonBlazorInterop.GetClass<globalThis>(
                    this.___guid,
                    "defaultView",
                    (entity) =>
                    {
                        return new globalThis() { ___guid = entity.___guid };
                    }
                );
            }
            return __defaultView;
            }
        }

        
        public string designMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "designMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "designMode",
                    value
                );
            }
        }

        
        public string dir
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "dir"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dir",
                    value
                );
            }
        }

        private DocumentTypeCachedEntity __doctype;
        public DocumentTypeCachedEntity doctype
        {
            get
            {
            if(__doctype == null)
            {
                __doctype = EventHorizonBlazorInterop.GetClass<DocumentTypeCachedEntity>(
                    this.___guid,
                    "doctype",
                    (entity) =>
                    {
                        return new DocumentTypeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __doctype;
            }
        }

        
        public CachedEntity documentElement
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "documentElement"
                );
            }
        }

        
        public string documentURI
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "documentURI"
                );
            }
        }

        
        public string domain
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "domain"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "domain",
                    value
                );
            }
        }

        private HTMLCollectionOfCachedEntity<HTMLEmbedElementCachedEntity> __embeds;
        public HTMLCollectionOfCachedEntity<HTMLEmbedElementCachedEntity> embeds
        {
            get
            {
            if(__embeds == null)
            {
                __embeds = EventHorizonBlazorInterop.GetClass<HTMLCollectionOfCachedEntity<HTMLEmbedElementCachedEntity>>(
                    this.___guid,
                    "embeds",
                    (entity) =>
                    {
                        return new HTMLCollectionOfCachedEntity<HTMLEmbedElementCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __embeds;
            }
        }

        
        public string fgColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fgColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fgColor",
                    value
                );
            }
        }

        private HTMLCollectionOfCachedEntity<HTMLFormElementCachedEntity> __forms;
        public HTMLCollectionOfCachedEntity<HTMLFormElementCachedEntity> forms
        {
            get
            {
            if(__forms == null)
            {
                __forms = EventHorizonBlazorInterop.GetClass<HTMLCollectionOfCachedEntity<HTMLFormElementCachedEntity>>(
                    this.___guid,
                    "forms",
                    (entity) =>
                    {
                        return new HTMLCollectionOfCachedEntity<HTMLFormElementCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __forms;
            }
        }

        
        public bool fullscreen
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "fullscreen"
                );
            }
        }

        
        public bool fullscreenEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "fullscreenEnabled"
                );
            }
        }

        private HTMLHeadElementCachedEntity __head;
        public HTMLHeadElementCachedEntity head
        {
            get
            {
            if(__head == null)
            {
                __head = EventHorizonBlazorInterop.GetClass<HTMLHeadElementCachedEntity>(
                    this.___guid,
                    "head",
                    (entity) =>
                    {
                        return new HTMLHeadElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __head;
            }
        }

        
        public bool hidden
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hidden"
                );
            }
        }

        private HTMLCollectionOfCachedEntity<HTMLImageElementCachedEntity> __images;
        public HTMLCollectionOfCachedEntity<HTMLImageElementCachedEntity> images
        {
            get
            {
            if(__images == null)
            {
                __images = EventHorizonBlazorInterop.GetClass<HTMLCollectionOfCachedEntity<HTMLImageElementCachedEntity>>(
                    this.___guid,
                    "images",
                    (entity) =>
                    {
                        return new HTMLCollectionOfCachedEntity<HTMLImageElementCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __images;
            }
        }

        private DOMImplementationCachedEntity __implementation;
        public DOMImplementationCachedEntity implementation
        {
            get
            {
            if(__implementation == null)
            {
                __implementation = EventHorizonBlazorInterop.GetClass<DOMImplementationCachedEntity>(
                    this.___guid,
                    "implementation",
                    (entity) =>
                    {
                        return new DOMImplementationCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __implementation;
            }
        }

        
        public string inputEncoding
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "inputEncoding"
                );
            }
        }

        
        public string lastModified
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "lastModified"
                );
            }
        }

        
        public string linkColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "linkColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "linkColor",
                    value
                );
            }
        }

        private HTMLCollectionOfCachedEntity<HTMLAnchorElementCachedEntity> __links;
        public HTMLCollectionOfCachedEntity<HTMLAnchorElementCachedEntity> links
        {
            get
            {
            if(__links == null)
            {
                __links = EventHorizonBlazorInterop.GetClass<HTMLCollectionOfCachedEntity<HTMLAnchorElementCachedEntity>>(
                    this.___guid,
                    "links",
                    (entity) =>
                    {
                        return new HTMLCollectionOfCachedEntity<HTMLAnchorElementCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __links;
            }
        }

        private LocationCachedEntity __location;
        public LocationCachedEntity location
        {
            get
            {
            if(__location == null)
            {
                __location = EventHorizonBlazorInterop.GetClass<LocationCachedEntity>(
                    this.___guid,
                    "location",
                    (entity) =>
                    {
                        return new LocationCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __location;
            }
            set
            {
__location = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "location",
                    value
                );
            }
        }

        
        public unknown ownerDocument
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "ownerDocument"
                );
            }
        }

        private HTMLCollectionOfCachedEntity<HTMLEmbedElementCachedEntity> __plugins;
        public HTMLCollectionOfCachedEntity<HTMLEmbedElementCachedEntity> plugins
        {
            get
            {
            if(__plugins == null)
            {
                __plugins = EventHorizonBlazorInterop.GetClass<HTMLCollectionOfCachedEntity<HTMLEmbedElementCachedEntity>>(
                    this.___guid,
                    "plugins",
                    (entity) =>
                    {
                        return new HTMLCollectionOfCachedEntity<HTMLEmbedElementCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __plugins;
            }
        }

        
        public CachedEntity readyState
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "readyState"
                );
            }
        }

        
        public string referrer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "referrer"
                );
            }
        }

        private HTMLCollectionOfCachedEntity<HTMLScriptElementCachedEntity> __scripts;
        public HTMLCollectionOfCachedEntity<HTMLScriptElementCachedEntity> scripts
        {
            get
            {
            if(__scripts == null)
            {
                __scripts = EventHorizonBlazorInterop.GetClass<HTMLCollectionOfCachedEntity<HTMLScriptElementCachedEntity>>(
                    this.___guid,
                    "scripts",
                    (entity) =>
                    {
                        return new HTMLCollectionOfCachedEntity<HTMLScriptElementCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __scripts;
            }
        }

        private ElementCachedEntity __scrollingElement;
        public ElementCachedEntity scrollingElement
        {
            get
            {
            if(__scrollingElement == null)
            {
                __scrollingElement = EventHorizonBlazorInterop.GetClass<ElementCachedEntity>(
                    this.___guid,
                    "scrollingElement",
                    (entity) =>
                    {
                        return new ElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __scrollingElement;
            }
        }

        private DocumentTimelineCachedEntity __timeline;
        public DocumentTimelineCachedEntity timeline
        {
            get
            {
            if(__timeline == null)
            {
                __timeline = EventHorizonBlazorInterop.GetClass<DocumentTimelineCachedEntity>(
                    this.___guid,
                    "timeline",
                    (entity) =>
                    {
                        return new DocumentTimelineCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __timeline;
            }
        }

        
        public string title
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "title"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "title",
                    value
                );
            }
        }

        
        public CachedEntity visibilityState
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "visibilityState"
                );
            }
        }

        
        public string vlinkColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "vlinkColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vlinkColor",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public DocumentCachedEntity() : base() { }

        public DocumentCachedEntity(
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

        #region onpointerlockchange TODO: Get Comments as metadata identification
        private bool _isOnpointerlockchangeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onpointerlockchangeActionMap = new Dictionary<string, Func<Task>>();

        public string onpointerlockchange(
            Func<Task> callback
        )
        {
            SetupOnpointerlockchangeLoop();

            var handle = Guid.NewGuid().ToString();
            _onpointerlockchangeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onpointerlockchange_Remove(
            string handle
        )
        {
            return _onpointerlockchangeActionMap.Remove(
                handle
            );
        }

        private void SetupOnpointerlockchangeLoop()
        {
            if (_isOnpointerlockchangeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onpointerlockchange",
                "CallOnpointerlockchangeActions",
                _invokableReference
            );
            _isOnpointerlockchangeEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnpointerlockchangeActions()
        {
            foreach (var action in _onpointerlockchangeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onpointerlockerror TODO: Get Comments as metadata identification
        private bool _isOnpointerlockerrorEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onpointerlockerrorActionMap = new Dictionary<string, Func<Task>>();

        public string onpointerlockerror(
            Func<Task> callback
        )
        {
            SetupOnpointerlockerrorLoop();

            var handle = Guid.NewGuid().ToString();
            _onpointerlockerrorActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onpointerlockerror_Remove(
            string handle
        )
        {
            return _onpointerlockerrorActionMap.Remove(
                handle
            );
        }

        private void SetupOnpointerlockerrorLoop()
        {
            if (_isOnpointerlockerrorEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onpointerlockerror",
                "CallOnpointerlockerrorActions",
                _invokableReference
            );
            _isOnpointerlockerrorEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnpointerlockerrorActions()
        {
            foreach (var action in _onpointerlockerrorActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onreadystatechange TODO: Get Comments as metadata identification
        private bool _isOnreadystatechangeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onreadystatechangeActionMap = new Dictionary<string, Func<Task>>();

        public string onreadystatechange(
            Func<Task> callback
        )
        {
            SetupOnreadystatechangeLoop();

            var handle = Guid.NewGuid().ToString();
            _onreadystatechangeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onreadystatechange_Remove(
            string handle
        )
        {
            return _onreadystatechangeActionMap.Remove(
                handle
            );
        }

        private void SetupOnreadystatechangeLoop()
        {
            if (_isOnreadystatechangeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onreadystatechange",
                "CallOnreadystatechangeActions",
                _invokableReference
            );
            _isOnreadystatechangeEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnreadystatechangeActions()
        {
            foreach (var action in _onreadystatechangeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onvisibilitychange TODO: Get Comments as metadata identification
        private bool _isOnvisibilitychangeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onvisibilitychangeActionMap = new Dictionary<string, Func<Task>>();

        public string onvisibilitychange(
            Func<Task> callback
        )
        {
            SetupOnvisibilitychangeLoop();

            var handle = Guid.NewGuid().ToString();
            _onvisibilitychangeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onvisibilitychange_Remove(
            string handle
        )
        {
            return _onvisibilitychangeActionMap.Remove(
                handle
            );
        }

        private void SetupOnvisibilitychangeLoop()
        {
            if (_isOnvisibilitychangeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onvisibilitychange",
                "CallOnvisibilitychangeActions",
                _invokableReference
            );
            _isOnvisibilitychangeEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnvisibilitychangeActions()
        {
            foreach (var action in _onvisibilitychangeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public T adoptNode(T source)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "adoptNode" }, source
                }
            );
        }

        public void captureEvents()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "captureEvents" }
                }
            );
        }

        public CaretPositionCachedEntity caretPositionFromPoint(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<CaretPositionCachedEntity>(
                entity => new CaretPositionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "caretPositionFromPoint" }, x, y
                }
            );
        }

        public RangeCachedEntity caretRangeFromPoint(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<RangeCachedEntity>(
                entity => new RangeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "caretRangeFromPoint" }, x, y
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public void close()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "close" }
                }
            );
        }

        public AttrCachedEntity createAttribute(string localName)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createAttribute" }, localName
                }
            );
        }

        public AttrCachedEntity createAttributeNS(string qualifiedName, string namespace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createAttributeNS" }, namespace, qualifiedName
                }
            );
        }

        public CDATASectionCachedEntity createCDATASection(string data)
        {
            return EventHorizonBlazorInterop.FuncClass<CDATASectionCachedEntity>(
                entity => new CDATASectionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createCDATASection" }, data
                }
            );
        }

        public CommentCachedEntity createComment(string data)
        {
            return EventHorizonBlazorInterop.FuncClass<CommentCachedEntity>(
                entity => new CommentCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createComment" }, data
                }
            );
        }

        public DocumentFragmentCachedEntity createDocumentFragment()
        {
            return EventHorizonBlazorInterop.FuncClass<DocumentFragmentCachedEntity>(
                entity => new DocumentFragmentCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDocumentFragment" }
                }
            );
        }

        public K createElement(K tagName, ElementCreationOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<K>(
                entity => new K() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createElement" }, tagName, options
                }
            );
        }

        public CachedEntity createElementNS(object namespaceURI, string qualifiedName)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createElementNS" }, namespaceURI, qualifiedName
                }
            );
        }

        public AnimationEventCachedEntity createEvent(object eventInterface)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationEventCachedEntity>(
                entity => new AnimationEventCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createEvent" }, eventInterface
                }
            );
        }

        public NodeIteratorCachedEntity createNodeIterator(Node root, System.Nullable<decimal> whatToShow = null, NodeFilter filter = null)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeIteratorCachedEntity>(
                entity => new NodeIteratorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createNodeIterator" }, root, whatToShow, filter
                }
            );
        }

        public ProcessingInstructionCachedEntity createProcessingInstruction(string target, string data)
        {
            return EventHorizonBlazorInterop.FuncClass<ProcessingInstructionCachedEntity>(
                entity => new ProcessingInstructionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createProcessingInstruction" }, target, data
                }
            );
        }

        public RangeCachedEntity createRange()
        {
            return EventHorizonBlazorInterop.FuncClass<RangeCachedEntity>(
                entity => new RangeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createRange" }
                }
            );
        }

        public TextCachedEntity createTextNode(string data)
        {
            return EventHorizonBlazorInterop.FuncClass<TextCachedEntity>(
                entity => new TextCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createTextNode" }, data
                }
            );
        }

        public TreeWalkerCachedEntity createTreeWalker(Node root, System.Nullable<decimal> whatToShow = null, NodeFilter filter = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TreeWalkerCachedEntity>(
                entity => new TreeWalkerCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createTreeWalker" }, root, whatToShow, filter
                }
            );
        }

        public ElementCachedEntity elementFromPoint(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<ElementCachedEntity>(
                entity => new ElementCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "elementFromPoint" }, x, y
                }
            );
        }

        public ElementCachedEntity[] elementsFromPoint(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<ElementCachedEntity>(
                entity => new ElementCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "elementsFromPoint" }, x, y
                }
            );
        }

        public bool execCommand(string commandId, System.Nullable<bool> showUI = null, string value = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "execCommand" }, commandId, showUI, value
                }
            );
        }

        public async ValueTask exitFullscreen()
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "exitFullscreen" }
                }
            );
        }

        public void exitPointerLock()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "exitPointerLock" }
                }
            );
        }

        public AnimationCachedEntity[] getAnimations()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationCachedEntity>(
                entity => new AnimationCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimations" }
                }
            );
        }

        public CachedEntity getElementById(string elementId)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getElementById" }, elementId
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

        public NodeListOfCachedEntity<CachedEntity> getElementsByName(string elementName)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeListOfCachedEntity<CachedEntity>>(
                entity => new NodeListOfCachedEntity<CachedEntity>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getElementsByName" }, elementName
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

        public SelectionCachedEntity getSelection()
        {
            return EventHorizonBlazorInterop.FuncClass<SelectionCachedEntity>(
                entity => new SelectionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSelection" }
                }
            );
        }

        public bool hasFocus()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasFocus" }
                }
            );
        }

        public T importNode(T importedNode, bool deep)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "importNode" }, importedNode, deep
                }
            );
        }

        public DocumentCachedEntity open(string url = null, string name = null, string features = null, System.Nullable<bool> replace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DocumentCachedEntity>(
                entity => new DocumentCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "open" }, url, name, features, replace
                }
            );
        }

        public bool queryCommandEnabled(string commandId)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "queryCommandEnabled" }, commandId
                }
            );
        }

        public bool queryCommandIndeterm(string commandId)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "queryCommandIndeterm" }, commandId
                }
            );
        }

        public bool queryCommandState(string commandId)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "queryCommandState" }, commandId
                }
            );
        }

        public bool queryCommandSupported(string commandId)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "queryCommandSupported" }, commandId
                }
            );
        }

        public string queryCommandValue(string commandId)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "queryCommandValue" }, commandId
                }
            );
        }

        public void releaseEvents()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "releaseEvents" }
                }
            );
        }

        public void write(string[] text)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "write" }, text
                }
            );
        }

        public void writeln(string[] text)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "writeln" }, text
                }
            );
        }

        public void addEventListener(K type, ActionCallback<Document, K> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEventListener" }, type, listener, options
                }
            );
        }

        public void removeEventListener(K type, ActionCallback<Document, K> listener, System.Nullable<bool> options = null)
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