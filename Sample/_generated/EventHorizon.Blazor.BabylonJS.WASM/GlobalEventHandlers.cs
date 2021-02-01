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

    public interface GlobalEventHandlers : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<GlobalEventHandlersCachedEntity>))]
    public class GlobalEventHandlersCachedEntity : CachedEntityObject, GlobalEventHandlers
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
        
        public OnErrorEventHandlerNonNullCachedEntity onerror
        {
            get
            {
            return EventHorizonBlazorInterop.Get<OnErrorEventHandlerNonNullCachedEntity>(
                    this.___guid,
                    "onerror"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onerror",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public GlobalEventHandlersCachedEntity() : base() { }

        public GlobalEventHandlersCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        #region onabort TODO: Get Comments as metadata identification
        private bool _isOnabortEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onabortActionMap = new Dictionary<string, Func<Task>>();

        public string onabort(
            Func<Task> callback
        )
        {
            SetupOnabortLoop();

            var handle = Guid.NewGuid().ToString();
            _onabortActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onabort_Remove(
            string handle
        )
        {
            return _onabortActionMap.Remove(
                handle
            );
        }

        private void SetupOnabortLoop()
        {
            if (_isOnabortEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onabort",
                "CallOnabortActions",
                _invokableReference
            );
            _isOnabortEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnabortActions()
        {
            foreach (var action in _onabortActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onanimationcancel TODO: Get Comments as metadata identification
        private bool _isOnanimationcancelEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onanimationcancelActionMap = new Dictionary<string, Func<Task>>();

        public string onanimationcancel(
            Func<Task> callback
        )
        {
            SetupOnanimationcancelLoop();

            var handle = Guid.NewGuid().ToString();
            _onanimationcancelActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onanimationcancel_Remove(
            string handle
        )
        {
            return _onanimationcancelActionMap.Remove(
                handle
            );
        }

        private void SetupOnanimationcancelLoop()
        {
            if (_isOnanimationcancelEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onanimationcancel",
                "CallOnanimationcancelActions",
                _invokableReference
            );
            _isOnanimationcancelEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnanimationcancelActions()
        {
            foreach (var action in _onanimationcancelActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onanimationend TODO: Get Comments as metadata identification
        private bool _isOnanimationendEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onanimationendActionMap = new Dictionary<string, Func<Task>>();

        public string onanimationend(
            Func<Task> callback
        )
        {
            SetupOnanimationendLoop();

            var handle = Guid.NewGuid().ToString();
            _onanimationendActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onanimationend_Remove(
            string handle
        )
        {
            return _onanimationendActionMap.Remove(
                handle
            );
        }

        private void SetupOnanimationendLoop()
        {
            if (_isOnanimationendEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onanimationend",
                "CallOnanimationendActions",
                _invokableReference
            );
            _isOnanimationendEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnanimationendActions()
        {
            foreach (var action in _onanimationendActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onanimationiteration TODO: Get Comments as metadata identification
        private bool _isOnanimationiterationEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onanimationiterationActionMap = new Dictionary<string, Func<Task>>();

        public string onanimationiteration(
            Func<Task> callback
        )
        {
            SetupOnanimationiterationLoop();

            var handle = Guid.NewGuid().ToString();
            _onanimationiterationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onanimationiteration_Remove(
            string handle
        )
        {
            return _onanimationiterationActionMap.Remove(
                handle
            );
        }

        private void SetupOnanimationiterationLoop()
        {
            if (_isOnanimationiterationEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onanimationiteration",
                "CallOnanimationiterationActions",
                _invokableReference
            );
            _isOnanimationiterationEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnanimationiterationActions()
        {
            foreach (var action in _onanimationiterationActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onanimationstart TODO: Get Comments as metadata identification
        private bool _isOnanimationstartEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onanimationstartActionMap = new Dictionary<string, Func<Task>>();

        public string onanimationstart(
            Func<Task> callback
        )
        {
            SetupOnanimationstartLoop();

            var handle = Guid.NewGuid().ToString();
            _onanimationstartActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onanimationstart_Remove(
            string handle
        )
        {
            return _onanimationstartActionMap.Remove(
                handle
            );
        }

        private void SetupOnanimationstartLoop()
        {
            if (_isOnanimationstartEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onanimationstart",
                "CallOnanimationstartActions",
                _invokableReference
            );
            _isOnanimationstartEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnanimationstartActions()
        {
            foreach (var action in _onanimationstartActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onauxclick TODO: Get Comments as metadata identification
        private bool _isOnauxclickEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onauxclickActionMap = new Dictionary<string, Func<Task>>();

        public string onauxclick(
            Func<Task> callback
        )
        {
            SetupOnauxclickLoop();

            var handle = Guid.NewGuid().ToString();
            _onauxclickActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onauxclick_Remove(
            string handle
        )
        {
            return _onauxclickActionMap.Remove(
                handle
            );
        }

        private void SetupOnauxclickLoop()
        {
            if (_isOnauxclickEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onauxclick",
                "CallOnauxclickActions",
                _invokableReference
            );
            _isOnauxclickEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnauxclickActions()
        {
            foreach (var action in _onauxclickActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onblur TODO: Get Comments as metadata identification
        private bool _isOnblurEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onblurActionMap = new Dictionary<string, Func<Task>>();

        public string onblur(
            Func<Task> callback
        )
        {
            SetupOnblurLoop();

            var handle = Guid.NewGuid().ToString();
            _onblurActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onblur_Remove(
            string handle
        )
        {
            return _onblurActionMap.Remove(
                handle
            );
        }

        private void SetupOnblurLoop()
        {
            if (_isOnblurEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onblur",
                "CallOnblurActions",
                _invokableReference
            );
            _isOnblurEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnblurActions()
        {
            foreach (var action in _onblurActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region oncancel TODO: Get Comments as metadata identification
        private bool _isOncancelEnabled = false;
        private readonly IDictionary<string, Func<Task>> _oncancelActionMap = new Dictionary<string, Func<Task>>();

        public string oncancel(
            Func<Task> callback
        )
        {
            SetupOncancelLoop();

            var handle = Guid.NewGuid().ToString();
            _oncancelActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool oncancel_Remove(
            string handle
        )
        {
            return _oncancelActionMap.Remove(
                handle
            );
        }

        private void SetupOncancelLoop()
        {
            if (_isOncancelEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "oncancel",
                "CallOncancelActions",
                _invokableReference
            );
            _isOncancelEnabled = true;
        }

        [JSInvokable]
        public async Task CallOncancelActions()
        {
            foreach (var action in _oncancelActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region oncanplay TODO: Get Comments as metadata identification
        private bool _isOncanplayEnabled = false;
        private readonly IDictionary<string, Func<Task>> _oncanplayActionMap = new Dictionary<string, Func<Task>>();

        public string oncanplay(
            Func<Task> callback
        )
        {
            SetupOncanplayLoop();

            var handle = Guid.NewGuid().ToString();
            _oncanplayActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool oncanplay_Remove(
            string handle
        )
        {
            return _oncanplayActionMap.Remove(
                handle
            );
        }

        private void SetupOncanplayLoop()
        {
            if (_isOncanplayEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "oncanplay",
                "CallOncanplayActions",
                _invokableReference
            );
            _isOncanplayEnabled = true;
        }

        [JSInvokable]
        public async Task CallOncanplayActions()
        {
            foreach (var action in _oncanplayActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region oncanplaythrough TODO: Get Comments as metadata identification
        private bool _isOncanplaythroughEnabled = false;
        private readonly IDictionary<string, Func<Task>> _oncanplaythroughActionMap = new Dictionary<string, Func<Task>>();

        public string oncanplaythrough(
            Func<Task> callback
        )
        {
            SetupOncanplaythroughLoop();

            var handle = Guid.NewGuid().ToString();
            _oncanplaythroughActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool oncanplaythrough_Remove(
            string handle
        )
        {
            return _oncanplaythroughActionMap.Remove(
                handle
            );
        }

        private void SetupOncanplaythroughLoop()
        {
            if (_isOncanplaythroughEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "oncanplaythrough",
                "CallOncanplaythroughActions",
                _invokableReference
            );
            _isOncanplaythroughEnabled = true;
        }

        [JSInvokable]
        public async Task CallOncanplaythroughActions()
        {
            foreach (var action in _oncanplaythroughActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onchange TODO: Get Comments as metadata identification
        private bool _isOnchangeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onchangeActionMap = new Dictionary<string, Func<Task>>();

        public string onchange(
            Func<Task> callback
        )
        {
            SetupOnchangeLoop();

            var handle = Guid.NewGuid().ToString();
            _onchangeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onchange_Remove(
            string handle
        )
        {
            return _onchangeActionMap.Remove(
                handle
            );
        }

        private void SetupOnchangeLoop()
        {
            if (_isOnchangeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onchange",
                "CallOnchangeActions",
                _invokableReference
            );
            _isOnchangeEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnchangeActions()
        {
            foreach (var action in _onchangeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onclick TODO: Get Comments as metadata identification
        private bool _isOnclickEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onclickActionMap = new Dictionary<string, Func<Task>>();

        public string onclick(
            Func<Task> callback
        )
        {
            SetupOnclickLoop();

            var handle = Guid.NewGuid().ToString();
            _onclickActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onclick_Remove(
            string handle
        )
        {
            return _onclickActionMap.Remove(
                handle
            );
        }

        private void SetupOnclickLoop()
        {
            if (_isOnclickEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onclick",
                "CallOnclickActions",
                _invokableReference
            );
            _isOnclickEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnclickActions()
        {
            foreach (var action in _onclickActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onclose TODO: Get Comments as metadata identification
        private bool _isOncloseEnabled = false;
        private readonly IDictionary<string, Func<Task>> _oncloseActionMap = new Dictionary<string, Func<Task>>();

        public string onclose(
            Func<Task> callback
        )
        {
            SetupOncloseLoop();

            var handle = Guid.NewGuid().ToString();
            _oncloseActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onclose_Remove(
            string handle
        )
        {
            return _oncloseActionMap.Remove(
                handle
            );
        }

        private void SetupOncloseLoop()
        {
            if (_isOncloseEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onclose",
                "CallOncloseActions",
                _invokableReference
            );
            _isOncloseEnabled = true;
        }

        [JSInvokable]
        public async Task CallOncloseActions()
        {
            foreach (var action in _oncloseActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region oncontextmenu TODO: Get Comments as metadata identification
        private bool _isOncontextmenuEnabled = false;
        private readonly IDictionary<string, Func<Task>> _oncontextmenuActionMap = new Dictionary<string, Func<Task>>();

        public string oncontextmenu(
            Func<Task> callback
        )
        {
            SetupOncontextmenuLoop();

            var handle = Guid.NewGuid().ToString();
            _oncontextmenuActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool oncontextmenu_Remove(
            string handle
        )
        {
            return _oncontextmenuActionMap.Remove(
                handle
            );
        }

        private void SetupOncontextmenuLoop()
        {
            if (_isOncontextmenuEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "oncontextmenu",
                "CallOncontextmenuActions",
                _invokableReference
            );
            _isOncontextmenuEnabled = true;
        }

        [JSInvokable]
        public async Task CallOncontextmenuActions()
        {
            foreach (var action in _oncontextmenuActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region oncuechange TODO: Get Comments as metadata identification
        private bool _isOncuechangeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _oncuechangeActionMap = new Dictionary<string, Func<Task>>();

        public string oncuechange(
            Func<Task> callback
        )
        {
            SetupOncuechangeLoop();

            var handle = Guid.NewGuid().ToString();
            _oncuechangeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool oncuechange_Remove(
            string handle
        )
        {
            return _oncuechangeActionMap.Remove(
                handle
            );
        }

        private void SetupOncuechangeLoop()
        {
            if (_isOncuechangeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "oncuechange",
                "CallOncuechangeActions",
                _invokableReference
            );
            _isOncuechangeEnabled = true;
        }

        [JSInvokable]
        public async Task CallOncuechangeActions()
        {
            foreach (var action in _oncuechangeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ondblclick TODO: Get Comments as metadata identification
        private bool _isOndblclickEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ondblclickActionMap = new Dictionary<string, Func<Task>>();

        public string ondblclick(
            Func<Task> callback
        )
        {
            SetupOndblclickLoop();

            var handle = Guid.NewGuid().ToString();
            _ondblclickActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ondblclick_Remove(
            string handle
        )
        {
            return _ondblclickActionMap.Remove(
                handle
            );
        }

        private void SetupOndblclickLoop()
        {
            if (_isOndblclickEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ondblclick",
                "CallOndblclickActions",
                _invokableReference
            );
            _isOndblclickEnabled = true;
        }

        [JSInvokable]
        public async Task CallOndblclickActions()
        {
            foreach (var action in _ondblclickActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ondrag TODO: Get Comments as metadata identification
        private bool _isOndragEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ondragActionMap = new Dictionary<string, Func<Task>>();

        public string ondrag(
            Func<Task> callback
        )
        {
            SetupOndragLoop();

            var handle = Guid.NewGuid().ToString();
            _ondragActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ondrag_Remove(
            string handle
        )
        {
            return _ondragActionMap.Remove(
                handle
            );
        }

        private void SetupOndragLoop()
        {
            if (_isOndragEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ondrag",
                "CallOndragActions",
                _invokableReference
            );
            _isOndragEnabled = true;
        }

        [JSInvokable]
        public async Task CallOndragActions()
        {
            foreach (var action in _ondragActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ondragend TODO: Get Comments as metadata identification
        private bool _isOndragendEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ondragendActionMap = new Dictionary<string, Func<Task>>();

        public string ondragend(
            Func<Task> callback
        )
        {
            SetupOndragendLoop();

            var handle = Guid.NewGuid().ToString();
            _ondragendActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ondragend_Remove(
            string handle
        )
        {
            return _ondragendActionMap.Remove(
                handle
            );
        }

        private void SetupOndragendLoop()
        {
            if (_isOndragendEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ondragend",
                "CallOndragendActions",
                _invokableReference
            );
            _isOndragendEnabled = true;
        }

        [JSInvokable]
        public async Task CallOndragendActions()
        {
            foreach (var action in _ondragendActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ondragenter TODO: Get Comments as metadata identification
        private bool _isOndragenterEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ondragenterActionMap = new Dictionary<string, Func<Task>>();

        public string ondragenter(
            Func<Task> callback
        )
        {
            SetupOndragenterLoop();

            var handle = Guid.NewGuid().ToString();
            _ondragenterActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ondragenter_Remove(
            string handle
        )
        {
            return _ondragenterActionMap.Remove(
                handle
            );
        }

        private void SetupOndragenterLoop()
        {
            if (_isOndragenterEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ondragenter",
                "CallOndragenterActions",
                _invokableReference
            );
            _isOndragenterEnabled = true;
        }

        [JSInvokable]
        public async Task CallOndragenterActions()
        {
            foreach (var action in _ondragenterActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ondragexit TODO: Get Comments as metadata identification
        private bool _isOndragexitEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ondragexitActionMap = new Dictionary<string, Func<Task>>();

        public string ondragexit(
            Func<Task> callback
        )
        {
            SetupOndragexitLoop();

            var handle = Guid.NewGuid().ToString();
            _ondragexitActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ondragexit_Remove(
            string handle
        )
        {
            return _ondragexitActionMap.Remove(
                handle
            );
        }

        private void SetupOndragexitLoop()
        {
            if (_isOndragexitEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ondragexit",
                "CallOndragexitActions",
                _invokableReference
            );
            _isOndragexitEnabled = true;
        }

        [JSInvokable]
        public async Task CallOndragexitActions()
        {
            foreach (var action in _ondragexitActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ondragleave TODO: Get Comments as metadata identification
        private bool _isOndragleaveEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ondragleaveActionMap = new Dictionary<string, Func<Task>>();

        public string ondragleave(
            Func<Task> callback
        )
        {
            SetupOndragleaveLoop();

            var handle = Guid.NewGuid().ToString();
            _ondragleaveActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ondragleave_Remove(
            string handle
        )
        {
            return _ondragleaveActionMap.Remove(
                handle
            );
        }

        private void SetupOndragleaveLoop()
        {
            if (_isOndragleaveEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ondragleave",
                "CallOndragleaveActions",
                _invokableReference
            );
            _isOndragleaveEnabled = true;
        }

        [JSInvokable]
        public async Task CallOndragleaveActions()
        {
            foreach (var action in _ondragleaveActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ondragover TODO: Get Comments as metadata identification
        private bool _isOndragoverEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ondragoverActionMap = new Dictionary<string, Func<Task>>();

        public string ondragover(
            Func<Task> callback
        )
        {
            SetupOndragoverLoop();

            var handle = Guid.NewGuid().ToString();
            _ondragoverActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ondragover_Remove(
            string handle
        )
        {
            return _ondragoverActionMap.Remove(
                handle
            );
        }

        private void SetupOndragoverLoop()
        {
            if (_isOndragoverEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ondragover",
                "CallOndragoverActions",
                _invokableReference
            );
            _isOndragoverEnabled = true;
        }

        [JSInvokable]
        public async Task CallOndragoverActions()
        {
            foreach (var action in _ondragoverActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ondragstart TODO: Get Comments as metadata identification
        private bool _isOndragstartEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ondragstartActionMap = new Dictionary<string, Func<Task>>();

        public string ondragstart(
            Func<Task> callback
        )
        {
            SetupOndragstartLoop();

            var handle = Guid.NewGuid().ToString();
            _ondragstartActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ondragstart_Remove(
            string handle
        )
        {
            return _ondragstartActionMap.Remove(
                handle
            );
        }

        private void SetupOndragstartLoop()
        {
            if (_isOndragstartEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ondragstart",
                "CallOndragstartActions",
                _invokableReference
            );
            _isOndragstartEnabled = true;
        }

        [JSInvokable]
        public async Task CallOndragstartActions()
        {
            foreach (var action in _ondragstartActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ondrop TODO: Get Comments as metadata identification
        private bool _isOndropEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ondropActionMap = new Dictionary<string, Func<Task>>();

        public string ondrop(
            Func<Task> callback
        )
        {
            SetupOndropLoop();

            var handle = Guid.NewGuid().ToString();
            _ondropActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ondrop_Remove(
            string handle
        )
        {
            return _ondropActionMap.Remove(
                handle
            );
        }

        private void SetupOndropLoop()
        {
            if (_isOndropEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ondrop",
                "CallOndropActions",
                _invokableReference
            );
            _isOndropEnabled = true;
        }

        [JSInvokable]
        public async Task CallOndropActions()
        {
            foreach (var action in _ondropActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ondurationchange TODO: Get Comments as metadata identification
        private bool _isOndurationchangeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ondurationchangeActionMap = new Dictionary<string, Func<Task>>();

        public string ondurationchange(
            Func<Task> callback
        )
        {
            SetupOndurationchangeLoop();

            var handle = Guid.NewGuid().ToString();
            _ondurationchangeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ondurationchange_Remove(
            string handle
        )
        {
            return _ondurationchangeActionMap.Remove(
                handle
            );
        }

        private void SetupOndurationchangeLoop()
        {
            if (_isOndurationchangeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ondurationchange",
                "CallOndurationchangeActions",
                _invokableReference
            );
            _isOndurationchangeEnabled = true;
        }

        [JSInvokable]
        public async Task CallOndurationchangeActions()
        {
            foreach (var action in _ondurationchangeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onemptied TODO: Get Comments as metadata identification
        private bool _isOnemptiedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onemptiedActionMap = new Dictionary<string, Func<Task>>();

        public string onemptied(
            Func<Task> callback
        )
        {
            SetupOnemptiedLoop();

            var handle = Guid.NewGuid().ToString();
            _onemptiedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onemptied_Remove(
            string handle
        )
        {
            return _onemptiedActionMap.Remove(
                handle
            );
        }

        private void SetupOnemptiedLoop()
        {
            if (_isOnemptiedEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onemptied",
                "CallOnemptiedActions",
                _invokableReference
            );
            _isOnemptiedEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnemptiedActions()
        {
            foreach (var action in _onemptiedActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onended TODO: Get Comments as metadata identification
        private bool _isOnendedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onendedActionMap = new Dictionary<string, Func<Task>>();

        public string onended(
            Func<Task> callback
        )
        {
            SetupOnendedLoop();

            var handle = Guid.NewGuid().ToString();
            _onendedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onended_Remove(
            string handle
        )
        {
            return _onendedActionMap.Remove(
                handle
            );
        }

        private void SetupOnendedLoop()
        {
            if (_isOnendedEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onended",
                "CallOnendedActions",
                _invokableReference
            );
            _isOnendedEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnendedActions()
        {
            foreach (var action in _onendedActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onfocus TODO: Get Comments as metadata identification
        private bool _isOnfocusEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onfocusActionMap = new Dictionary<string, Func<Task>>();

        public string onfocus(
            Func<Task> callback
        )
        {
            SetupOnfocusLoop();

            var handle = Guid.NewGuid().ToString();
            _onfocusActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onfocus_Remove(
            string handle
        )
        {
            return _onfocusActionMap.Remove(
                handle
            );
        }

        private void SetupOnfocusLoop()
        {
            if (_isOnfocusEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onfocus",
                "CallOnfocusActions",
                _invokableReference
            );
            _isOnfocusEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnfocusActions()
        {
            foreach (var action in _onfocusActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ongotpointercapture TODO: Get Comments as metadata identification
        private bool _isOngotpointercaptureEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ongotpointercaptureActionMap = new Dictionary<string, Func<Task>>();

        public string ongotpointercapture(
            Func<Task> callback
        )
        {
            SetupOngotpointercaptureLoop();

            var handle = Guid.NewGuid().ToString();
            _ongotpointercaptureActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ongotpointercapture_Remove(
            string handle
        )
        {
            return _ongotpointercaptureActionMap.Remove(
                handle
            );
        }

        private void SetupOngotpointercaptureLoop()
        {
            if (_isOngotpointercaptureEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ongotpointercapture",
                "CallOngotpointercaptureActions",
                _invokableReference
            );
            _isOngotpointercaptureEnabled = true;
        }

        [JSInvokable]
        public async Task CallOngotpointercaptureActions()
        {
            foreach (var action in _ongotpointercaptureActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region oninput TODO: Get Comments as metadata identification
        private bool _isOninputEnabled = false;
        private readonly IDictionary<string, Func<Task>> _oninputActionMap = new Dictionary<string, Func<Task>>();

        public string oninput(
            Func<Task> callback
        )
        {
            SetupOninputLoop();

            var handle = Guid.NewGuid().ToString();
            _oninputActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool oninput_Remove(
            string handle
        )
        {
            return _oninputActionMap.Remove(
                handle
            );
        }

        private void SetupOninputLoop()
        {
            if (_isOninputEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "oninput",
                "CallOninputActions",
                _invokableReference
            );
            _isOninputEnabled = true;
        }

        [JSInvokable]
        public async Task CallOninputActions()
        {
            foreach (var action in _oninputActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region oninvalid TODO: Get Comments as metadata identification
        private bool _isOninvalidEnabled = false;
        private readonly IDictionary<string, Func<Task>> _oninvalidActionMap = new Dictionary<string, Func<Task>>();

        public string oninvalid(
            Func<Task> callback
        )
        {
            SetupOninvalidLoop();

            var handle = Guid.NewGuid().ToString();
            _oninvalidActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool oninvalid_Remove(
            string handle
        )
        {
            return _oninvalidActionMap.Remove(
                handle
            );
        }

        private void SetupOninvalidLoop()
        {
            if (_isOninvalidEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "oninvalid",
                "CallOninvalidActions",
                _invokableReference
            );
            _isOninvalidEnabled = true;
        }

        [JSInvokable]
        public async Task CallOninvalidActions()
        {
            foreach (var action in _oninvalidActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onkeydown TODO: Get Comments as metadata identification
        private bool _isOnkeydownEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onkeydownActionMap = new Dictionary<string, Func<Task>>();

        public string onkeydown(
            Func<Task> callback
        )
        {
            SetupOnkeydownLoop();

            var handle = Guid.NewGuid().ToString();
            _onkeydownActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onkeydown_Remove(
            string handle
        )
        {
            return _onkeydownActionMap.Remove(
                handle
            );
        }

        private void SetupOnkeydownLoop()
        {
            if (_isOnkeydownEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onkeydown",
                "CallOnkeydownActions",
                _invokableReference
            );
            _isOnkeydownEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnkeydownActions()
        {
            foreach (var action in _onkeydownActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onkeypress TODO: Get Comments as metadata identification
        private bool _isOnkeypressEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onkeypressActionMap = new Dictionary<string, Func<Task>>();

        public string onkeypress(
            Func<Task> callback
        )
        {
            SetupOnkeypressLoop();

            var handle = Guid.NewGuid().ToString();
            _onkeypressActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onkeypress_Remove(
            string handle
        )
        {
            return _onkeypressActionMap.Remove(
                handle
            );
        }

        private void SetupOnkeypressLoop()
        {
            if (_isOnkeypressEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onkeypress",
                "CallOnkeypressActions",
                _invokableReference
            );
            _isOnkeypressEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnkeypressActions()
        {
            foreach (var action in _onkeypressActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onkeyup TODO: Get Comments as metadata identification
        private bool _isOnkeyupEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onkeyupActionMap = new Dictionary<string, Func<Task>>();

        public string onkeyup(
            Func<Task> callback
        )
        {
            SetupOnkeyupLoop();

            var handle = Guid.NewGuid().ToString();
            _onkeyupActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onkeyup_Remove(
            string handle
        )
        {
            return _onkeyupActionMap.Remove(
                handle
            );
        }

        private void SetupOnkeyupLoop()
        {
            if (_isOnkeyupEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onkeyup",
                "CallOnkeyupActions",
                _invokableReference
            );
            _isOnkeyupEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnkeyupActions()
        {
            foreach (var action in _onkeyupActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onload TODO: Get Comments as metadata identification
        private bool _isOnloadEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onloadActionMap = new Dictionary<string, Func<Task>>();

        public string onload(
            Func<Task> callback
        )
        {
            SetupOnloadLoop();

            var handle = Guid.NewGuid().ToString();
            _onloadActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onload_Remove(
            string handle
        )
        {
            return _onloadActionMap.Remove(
                handle
            );
        }

        private void SetupOnloadLoop()
        {
            if (_isOnloadEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onload",
                "CallOnloadActions",
                _invokableReference
            );
            _isOnloadEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnloadActions()
        {
            foreach (var action in _onloadActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onloadeddata TODO: Get Comments as metadata identification
        private bool _isOnloadeddataEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onloadeddataActionMap = new Dictionary<string, Func<Task>>();

        public string onloadeddata(
            Func<Task> callback
        )
        {
            SetupOnloadeddataLoop();

            var handle = Guid.NewGuid().ToString();
            _onloadeddataActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onloadeddata_Remove(
            string handle
        )
        {
            return _onloadeddataActionMap.Remove(
                handle
            );
        }

        private void SetupOnloadeddataLoop()
        {
            if (_isOnloadeddataEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onloadeddata",
                "CallOnloadeddataActions",
                _invokableReference
            );
            _isOnloadeddataEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnloadeddataActions()
        {
            foreach (var action in _onloadeddataActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onloadedmetadata TODO: Get Comments as metadata identification
        private bool _isOnloadedmetadataEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onloadedmetadataActionMap = new Dictionary<string, Func<Task>>();

        public string onloadedmetadata(
            Func<Task> callback
        )
        {
            SetupOnloadedmetadataLoop();

            var handle = Guid.NewGuid().ToString();
            _onloadedmetadataActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onloadedmetadata_Remove(
            string handle
        )
        {
            return _onloadedmetadataActionMap.Remove(
                handle
            );
        }

        private void SetupOnloadedmetadataLoop()
        {
            if (_isOnloadedmetadataEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onloadedmetadata",
                "CallOnloadedmetadataActions",
                _invokableReference
            );
            _isOnloadedmetadataEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnloadedmetadataActions()
        {
            foreach (var action in _onloadedmetadataActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onloadstart TODO: Get Comments as metadata identification
        private bool _isOnloadstartEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onloadstartActionMap = new Dictionary<string, Func<Task>>();

        public string onloadstart(
            Func<Task> callback
        )
        {
            SetupOnloadstartLoop();

            var handle = Guid.NewGuid().ToString();
            _onloadstartActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onloadstart_Remove(
            string handle
        )
        {
            return _onloadstartActionMap.Remove(
                handle
            );
        }

        private void SetupOnloadstartLoop()
        {
            if (_isOnloadstartEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onloadstart",
                "CallOnloadstartActions",
                _invokableReference
            );
            _isOnloadstartEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnloadstartActions()
        {
            foreach (var action in _onloadstartActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onlostpointercapture TODO: Get Comments as metadata identification
        private bool _isOnlostpointercaptureEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onlostpointercaptureActionMap = new Dictionary<string, Func<Task>>();

        public string onlostpointercapture(
            Func<Task> callback
        )
        {
            SetupOnlostpointercaptureLoop();

            var handle = Guid.NewGuid().ToString();
            _onlostpointercaptureActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onlostpointercapture_Remove(
            string handle
        )
        {
            return _onlostpointercaptureActionMap.Remove(
                handle
            );
        }

        private void SetupOnlostpointercaptureLoop()
        {
            if (_isOnlostpointercaptureEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onlostpointercapture",
                "CallOnlostpointercaptureActions",
                _invokableReference
            );
            _isOnlostpointercaptureEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnlostpointercaptureActions()
        {
            foreach (var action in _onlostpointercaptureActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onmousedown TODO: Get Comments as metadata identification
        private bool _isOnmousedownEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onmousedownActionMap = new Dictionary<string, Func<Task>>();

        public string onmousedown(
            Func<Task> callback
        )
        {
            SetupOnmousedownLoop();

            var handle = Guid.NewGuid().ToString();
            _onmousedownActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onmousedown_Remove(
            string handle
        )
        {
            return _onmousedownActionMap.Remove(
                handle
            );
        }

        private void SetupOnmousedownLoop()
        {
            if (_isOnmousedownEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onmousedown",
                "CallOnmousedownActions",
                _invokableReference
            );
            _isOnmousedownEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnmousedownActions()
        {
            foreach (var action in _onmousedownActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onmouseenter TODO: Get Comments as metadata identification
        private bool _isOnmouseenterEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onmouseenterActionMap = new Dictionary<string, Func<Task>>();

        public string onmouseenter(
            Func<Task> callback
        )
        {
            SetupOnmouseenterLoop();

            var handle = Guid.NewGuid().ToString();
            _onmouseenterActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onmouseenter_Remove(
            string handle
        )
        {
            return _onmouseenterActionMap.Remove(
                handle
            );
        }

        private void SetupOnmouseenterLoop()
        {
            if (_isOnmouseenterEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onmouseenter",
                "CallOnmouseenterActions",
                _invokableReference
            );
            _isOnmouseenterEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnmouseenterActions()
        {
            foreach (var action in _onmouseenterActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onmouseleave TODO: Get Comments as metadata identification
        private bool _isOnmouseleaveEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onmouseleaveActionMap = new Dictionary<string, Func<Task>>();

        public string onmouseleave(
            Func<Task> callback
        )
        {
            SetupOnmouseleaveLoop();

            var handle = Guid.NewGuid().ToString();
            _onmouseleaveActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onmouseleave_Remove(
            string handle
        )
        {
            return _onmouseleaveActionMap.Remove(
                handle
            );
        }

        private void SetupOnmouseleaveLoop()
        {
            if (_isOnmouseleaveEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onmouseleave",
                "CallOnmouseleaveActions",
                _invokableReference
            );
            _isOnmouseleaveEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnmouseleaveActions()
        {
            foreach (var action in _onmouseleaveActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onmousemove TODO: Get Comments as metadata identification
        private bool _isOnmousemoveEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onmousemoveActionMap = new Dictionary<string, Func<Task>>();

        public string onmousemove(
            Func<Task> callback
        )
        {
            SetupOnmousemoveLoop();

            var handle = Guid.NewGuid().ToString();
            _onmousemoveActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onmousemove_Remove(
            string handle
        )
        {
            return _onmousemoveActionMap.Remove(
                handle
            );
        }

        private void SetupOnmousemoveLoop()
        {
            if (_isOnmousemoveEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onmousemove",
                "CallOnmousemoveActions",
                _invokableReference
            );
            _isOnmousemoveEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnmousemoveActions()
        {
            foreach (var action in _onmousemoveActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onmouseout TODO: Get Comments as metadata identification
        private bool _isOnmouseoutEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onmouseoutActionMap = new Dictionary<string, Func<Task>>();

        public string onmouseout(
            Func<Task> callback
        )
        {
            SetupOnmouseoutLoop();

            var handle = Guid.NewGuid().ToString();
            _onmouseoutActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onmouseout_Remove(
            string handle
        )
        {
            return _onmouseoutActionMap.Remove(
                handle
            );
        }

        private void SetupOnmouseoutLoop()
        {
            if (_isOnmouseoutEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onmouseout",
                "CallOnmouseoutActions",
                _invokableReference
            );
            _isOnmouseoutEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnmouseoutActions()
        {
            foreach (var action in _onmouseoutActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onmouseover TODO: Get Comments as metadata identification
        private bool _isOnmouseoverEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onmouseoverActionMap = new Dictionary<string, Func<Task>>();

        public string onmouseover(
            Func<Task> callback
        )
        {
            SetupOnmouseoverLoop();

            var handle = Guid.NewGuid().ToString();
            _onmouseoverActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onmouseover_Remove(
            string handle
        )
        {
            return _onmouseoverActionMap.Remove(
                handle
            );
        }

        private void SetupOnmouseoverLoop()
        {
            if (_isOnmouseoverEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onmouseover",
                "CallOnmouseoverActions",
                _invokableReference
            );
            _isOnmouseoverEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnmouseoverActions()
        {
            foreach (var action in _onmouseoverActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onmouseup TODO: Get Comments as metadata identification
        private bool _isOnmouseupEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onmouseupActionMap = new Dictionary<string, Func<Task>>();

        public string onmouseup(
            Func<Task> callback
        )
        {
            SetupOnmouseupLoop();

            var handle = Guid.NewGuid().ToString();
            _onmouseupActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onmouseup_Remove(
            string handle
        )
        {
            return _onmouseupActionMap.Remove(
                handle
            );
        }

        private void SetupOnmouseupLoop()
        {
            if (_isOnmouseupEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onmouseup",
                "CallOnmouseupActions",
                _invokableReference
            );
            _isOnmouseupEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnmouseupActions()
        {
            foreach (var action in _onmouseupActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onpause TODO: Get Comments as metadata identification
        private bool _isOnpauseEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onpauseActionMap = new Dictionary<string, Func<Task>>();

        public string onpause(
            Func<Task> callback
        )
        {
            SetupOnpauseLoop();

            var handle = Guid.NewGuid().ToString();
            _onpauseActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onpause_Remove(
            string handle
        )
        {
            return _onpauseActionMap.Remove(
                handle
            );
        }

        private void SetupOnpauseLoop()
        {
            if (_isOnpauseEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onpause",
                "CallOnpauseActions",
                _invokableReference
            );
            _isOnpauseEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnpauseActions()
        {
            foreach (var action in _onpauseActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onplay TODO: Get Comments as metadata identification
        private bool _isOnplayEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onplayActionMap = new Dictionary<string, Func<Task>>();

        public string onplay(
            Func<Task> callback
        )
        {
            SetupOnplayLoop();

            var handle = Guid.NewGuid().ToString();
            _onplayActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onplay_Remove(
            string handle
        )
        {
            return _onplayActionMap.Remove(
                handle
            );
        }

        private void SetupOnplayLoop()
        {
            if (_isOnplayEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onplay",
                "CallOnplayActions",
                _invokableReference
            );
            _isOnplayEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnplayActions()
        {
            foreach (var action in _onplayActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onplaying TODO: Get Comments as metadata identification
        private bool _isOnplayingEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onplayingActionMap = new Dictionary<string, Func<Task>>();

        public string onplaying(
            Func<Task> callback
        )
        {
            SetupOnplayingLoop();

            var handle = Guid.NewGuid().ToString();
            _onplayingActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onplaying_Remove(
            string handle
        )
        {
            return _onplayingActionMap.Remove(
                handle
            );
        }

        private void SetupOnplayingLoop()
        {
            if (_isOnplayingEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onplaying",
                "CallOnplayingActions",
                _invokableReference
            );
            _isOnplayingEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnplayingActions()
        {
            foreach (var action in _onplayingActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onpointercancel TODO: Get Comments as metadata identification
        private bool _isOnpointercancelEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onpointercancelActionMap = new Dictionary<string, Func<Task>>();

        public string onpointercancel(
            Func<Task> callback
        )
        {
            SetupOnpointercancelLoop();

            var handle = Guid.NewGuid().ToString();
            _onpointercancelActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onpointercancel_Remove(
            string handle
        )
        {
            return _onpointercancelActionMap.Remove(
                handle
            );
        }

        private void SetupOnpointercancelLoop()
        {
            if (_isOnpointercancelEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onpointercancel",
                "CallOnpointercancelActions",
                _invokableReference
            );
            _isOnpointercancelEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnpointercancelActions()
        {
            foreach (var action in _onpointercancelActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onpointerdown TODO: Get Comments as metadata identification
        private bool _isOnpointerdownEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onpointerdownActionMap = new Dictionary<string, Func<Task>>();

        public string onpointerdown(
            Func<Task> callback
        )
        {
            SetupOnpointerdownLoop();

            var handle = Guid.NewGuid().ToString();
            _onpointerdownActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onpointerdown_Remove(
            string handle
        )
        {
            return _onpointerdownActionMap.Remove(
                handle
            );
        }

        private void SetupOnpointerdownLoop()
        {
            if (_isOnpointerdownEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onpointerdown",
                "CallOnpointerdownActions",
                _invokableReference
            );
            _isOnpointerdownEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnpointerdownActions()
        {
            foreach (var action in _onpointerdownActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onpointerenter TODO: Get Comments as metadata identification
        private bool _isOnpointerenterEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onpointerenterActionMap = new Dictionary<string, Func<Task>>();

        public string onpointerenter(
            Func<Task> callback
        )
        {
            SetupOnpointerenterLoop();

            var handle = Guid.NewGuid().ToString();
            _onpointerenterActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onpointerenter_Remove(
            string handle
        )
        {
            return _onpointerenterActionMap.Remove(
                handle
            );
        }

        private void SetupOnpointerenterLoop()
        {
            if (_isOnpointerenterEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onpointerenter",
                "CallOnpointerenterActions",
                _invokableReference
            );
            _isOnpointerenterEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnpointerenterActions()
        {
            foreach (var action in _onpointerenterActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onpointerleave TODO: Get Comments as metadata identification
        private bool _isOnpointerleaveEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onpointerleaveActionMap = new Dictionary<string, Func<Task>>();

        public string onpointerleave(
            Func<Task> callback
        )
        {
            SetupOnpointerleaveLoop();

            var handle = Guid.NewGuid().ToString();
            _onpointerleaveActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onpointerleave_Remove(
            string handle
        )
        {
            return _onpointerleaveActionMap.Remove(
                handle
            );
        }

        private void SetupOnpointerleaveLoop()
        {
            if (_isOnpointerleaveEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onpointerleave",
                "CallOnpointerleaveActions",
                _invokableReference
            );
            _isOnpointerleaveEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnpointerleaveActions()
        {
            foreach (var action in _onpointerleaveActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onpointermove TODO: Get Comments as metadata identification
        private bool _isOnpointermoveEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onpointermoveActionMap = new Dictionary<string, Func<Task>>();

        public string onpointermove(
            Func<Task> callback
        )
        {
            SetupOnpointermoveLoop();

            var handle = Guid.NewGuid().ToString();
            _onpointermoveActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onpointermove_Remove(
            string handle
        )
        {
            return _onpointermoveActionMap.Remove(
                handle
            );
        }

        private void SetupOnpointermoveLoop()
        {
            if (_isOnpointermoveEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onpointermove",
                "CallOnpointermoveActions",
                _invokableReference
            );
            _isOnpointermoveEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnpointermoveActions()
        {
            foreach (var action in _onpointermoveActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onpointerout TODO: Get Comments as metadata identification
        private bool _isOnpointeroutEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onpointeroutActionMap = new Dictionary<string, Func<Task>>();

        public string onpointerout(
            Func<Task> callback
        )
        {
            SetupOnpointeroutLoop();

            var handle = Guid.NewGuid().ToString();
            _onpointeroutActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onpointerout_Remove(
            string handle
        )
        {
            return _onpointeroutActionMap.Remove(
                handle
            );
        }

        private void SetupOnpointeroutLoop()
        {
            if (_isOnpointeroutEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onpointerout",
                "CallOnpointeroutActions",
                _invokableReference
            );
            _isOnpointeroutEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnpointeroutActions()
        {
            foreach (var action in _onpointeroutActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onpointerover TODO: Get Comments as metadata identification
        private bool _isOnpointeroverEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onpointeroverActionMap = new Dictionary<string, Func<Task>>();

        public string onpointerover(
            Func<Task> callback
        )
        {
            SetupOnpointeroverLoop();

            var handle = Guid.NewGuid().ToString();
            _onpointeroverActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onpointerover_Remove(
            string handle
        )
        {
            return _onpointeroverActionMap.Remove(
                handle
            );
        }

        private void SetupOnpointeroverLoop()
        {
            if (_isOnpointeroverEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onpointerover",
                "CallOnpointeroverActions",
                _invokableReference
            );
            _isOnpointeroverEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnpointeroverActions()
        {
            foreach (var action in _onpointeroverActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onpointerup TODO: Get Comments as metadata identification
        private bool _isOnpointerupEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onpointerupActionMap = new Dictionary<string, Func<Task>>();

        public string onpointerup(
            Func<Task> callback
        )
        {
            SetupOnpointerupLoop();

            var handle = Guid.NewGuid().ToString();
            _onpointerupActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onpointerup_Remove(
            string handle
        )
        {
            return _onpointerupActionMap.Remove(
                handle
            );
        }

        private void SetupOnpointerupLoop()
        {
            if (_isOnpointerupEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onpointerup",
                "CallOnpointerupActions",
                _invokableReference
            );
            _isOnpointerupEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnpointerupActions()
        {
            foreach (var action in _onpointerupActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onprogress TODO: Get Comments as metadata identification
        private bool _isOnprogressEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onprogressActionMap = new Dictionary<string, Func<Task>>();

        public string onprogress(
            Func<Task> callback
        )
        {
            SetupOnprogressLoop();

            var handle = Guid.NewGuid().ToString();
            _onprogressActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onprogress_Remove(
            string handle
        )
        {
            return _onprogressActionMap.Remove(
                handle
            );
        }

        private void SetupOnprogressLoop()
        {
            if (_isOnprogressEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onprogress",
                "CallOnprogressActions",
                _invokableReference
            );
            _isOnprogressEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnprogressActions()
        {
            foreach (var action in _onprogressActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onratechange TODO: Get Comments as metadata identification
        private bool _isOnratechangeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onratechangeActionMap = new Dictionary<string, Func<Task>>();

        public string onratechange(
            Func<Task> callback
        )
        {
            SetupOnratechangeLoop();

            var handle = Guid.NewGuid().ToString();
            _onratechangeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onratechange_Remove(
            string handle
        )
        {
            return _onratechangeActionMap.Remove(
                handle
            );
        }

        private void SetupOnratechangeLoop()
        {
            if (_isOnratechangeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onratechange",
                "CallOnratechangeActions",
                _invokableReference
            );
            _isOnratechangeEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnratechangeActions()
        {
            foreach (var action in _onratechangeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onreset TODO: Get Comments as metadata identification
        private bool _isOnresetEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onresetActionMap = new Dictionary<string, Func<Task>>();

        public string onreset(
            Func<Task> callback
        )
        {
            SetupOnresetLoop();

            var handle = Guid.NewGuid().ToString();
            _onresetActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onreset_Remove(
            string handle
        )
        {
            return _onresetActionMap.Remove(
                handle
            );
        }

        private void SetupOnresetLoop()
        {
            if (_isOnresetEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onreset",
                "CallOnresetActions",
                _invokableReference
            );
            _isOnresetEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnresetActions()
        {
            foreach (var action in _onresetActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onresize TODO: Get Comments as metadata identification
        private bool _isOnresizeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onresizeActionMap = new Dictionary<string, Func<Task>>();

        public string onresize(
            Func<Task> callback
        )
        {
            SetupOnresizeLoop();

            var handle = Guid.NewGuid().ToString();
            _onresizeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onresize_Remove(
            string handle
        )
        {
            return _onresizeActionMap.Remove(
                handle
            );
        }

        private void SetupOnresizeLoop()
        {
            if (_isOnresizeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onresize",
                "CallOnresizeActions",
                _invokableReference
            );
            _isOnresizeEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnresizeActions()
        {
            foreach (var action in _onresizeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onscroll TODO: Get Comments as metadata identification
        private bool _isOnscrollEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onscrollActionMap = new Dictionary<string, Func<Task>>();

        public string onscroll(
            Func<Task> callback
        )
        {
            SetupOnscrollLoop();

            var handle = Guid.NewGuid().ToString();
            _onscrollActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onscroll_Remove(
            string handle
        )
        {
            return _onscrollActionMap.Remove(
                handle
            );
        }

        private void SetupOnscrollLoop()
        {
            if (_isOnscrollEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onscroll",
                "CallOnscrollActions",
                _invokableReference
            );
            _isOnscrollEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnscrollActions()
        {
            foreach (var action in _onscrollActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onsecuritypolicyviolation TODO: Get Comments as metadata identification
        private bool _isOnsecuritypolicyviolationEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onsecuritypolicyviolationActionMap = new Dictionary<string, Func<Task>>();

        public string onsecuritypolicyviolation(
            Func<Task> callback
        )
        {
            SetupOnsecuritypolicyviolationLoop();

            var handle = Guid.NewGuid().ToString();
            _onsecuritypolicyviolationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onsecuritypolicyviolation_Remove(
            string handle
        )
        {
            return _onsecuritypolicyviolationActionMap.Remove(
                handle
            );
        }

        private void SetupOnsecuritypolicyviolationLoop()
        {
            if (_isOnsecuritypolicyviolationEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onsecuritypolicyviolation",
                "CallOnsecuritypolicyviolationActions",
                _invokableReference
            );
            _isOnsecuritypolicyviolationEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnsecuritypolicyviolationActions()
        {
            foreach (var action in _onsecuritypolicyviolationActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onseeked TODO: Get Comments as metadata identification
        private bool _isOnseekedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onseekedActionMap = new Dictionary<string, Func<Task>>();

        public string onseeked(
            Func<Task> callback
        )
        {
            SetupOnseekedLoop();

            var handle = Guid.NewGuid().ToString();
            _onseekedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onseeked_Remove(
            string handle
        )
        {
            return _onseekedActionMap.Remove(
                handle
            );
        }

        private void SetupOnseekedLoop()
        {
            if (_isOnseekedEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onseeked",
                "CallOnseekedActions",
                _invokableReference
            );
            _isOnseekedEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnseekedActions()
        {
            foreach (var action in _onseekedActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onseeking TODO: Get Comments as metadata identification
        private bool _isOnseekingEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onseekingActionMap = new Dictionary<string, Func<Task>>();

        public string onseeking(
            Func<Task> callback
        )
        {
            SetupOnseekingLoop();

            var handle = Guid.NewGuid().ToString();
            _onseekingActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onseeking_Remove(
            string handle
        )
        {
            return _onseekingActionMap.Remove(
                handle
            );
        }

        private void SetupOnseekingLoop()
        {
            if (_isOnseekingEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onseeking",
                "CallOnseekingActions",
                _invokableReference
            );
            _isOnseekingEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnseekingActions()
        {
            foreach (var action in _onseekingActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onselect TODO: Get Comments as metadata identification
        private bool _isOnselectEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onselectActionMap = new Dictionary<string, Func<Task>>();

        public string onselect(
            Func<Task> callback
        )
        {
            SetupOnselectLoop();

            var handle = Guid.NewGuid().ToString();
            _onselectActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onselect_Remove(
            string handle
        )
        {
            return _onselectActionMap.Remove(
                handle
            );
        }

        private void SetupOnselectLoop()
        {
            if (_isOnselectEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onselect",
                "CallOnselectActions",
                _invokableReference
            );
            _isOnselectEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnselectActions()
        {
            foreach (var action in _onselectActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onselectionchange TODO: Get Comments as metadata identification
        private bool _isOnselectionchangeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onselectionchangeActionMap = new Dictionary<string, Func<Task>>();

        public string onselectionchange(
            Func<Task> callback
        )
        {
            SetupOnselectionchangeLoop();

            var handle = Guid.NewGuid().ToString();
            _onselectionchangeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onselectionchange_Remove(
            string handle
        )
        {
            return _onselectionchangeActionMap.Remove(
                handle
            );
        }

        private void SetupOnselectionchangeLoop()
        {
            if (_isOnselectionchangeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onselectionchange",
                "CallOnselectionchangeActions",
                _invokableReference
            );
            _isOnselectionchangeEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnselectionchangeActions()
        {
            foreach (var action in _onselectionchangeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onselectstart TODO: Get Comments as metadata identification
        private bool _isOnselectstartEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onselectstartActionMap = new Dictionary<string, Func<Task>>();

        public string onselectstart(
            Func<Task> callback
        )
        {
            SetupOnselectstartLoop();

            var handle = Guid.NewGuid().ToString();
            _onselectstartActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onselectstart_Remove(
            string handle
        )
        {
            return _onselectstartActionMap.Remove(
                handle
            );
        }

        private void SetupOnselectstartLoop()
        {
            if (_isOnselectstartEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onselectstart",
                "CallOnselectstartActions",
                _invokableReference
            );
            _isOnselectstartEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnselectstartActions()
        {
            foreach (var action in _onselectstartActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onstalled TODO: Get Comments as metadata identification
        private bool _isOnstalledEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onstalledActionMap = new Dictionary<string, Func<Task>>();

        public string onstalled(
            Func<Task> callback
        )
        {
            SetupOnstalledLoop();

            var handle = Guid.NewGuid().ToString();
            _onstalledActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onstalled_Remove(
            string handle
        )
        {
            return _onstalledActionMap.Remove(
                handle
            );
        }

        private void SetupOnstalledLoop()
        {
            if (_isOnstalledEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onstalled",
                "CallOnstalledActions",
                _invokableReference
            );
            _isOnstalledEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnstalledActions()
        {
            foreach (var action in _onstalledActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onsubmit TODO: Get Comments as metadata identification
        private bool _isOnsubmitEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onsubmitActionMap = new Dictionary<string, Func<Task>>();

        public string onsubmit(
            Func<Task> callback
        )
        {
            SetupOnsubmitLoop();

            var handle = Guid.NewGuid().ToString();
            _onsubmitActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onsubmit_Remove(
            string handle
        )
        {
            return _onsubmitActionMap.Remove(
                handle
            );
        }

        private void SetupOnsubmitLoop()
        {
            if (_isOnsubmitEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onsubmit",
                "CallOnsubmitActions",
                _invokableReference
            );
            _isOnsubmitEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnsubmitActions()
        {
            foreach (var action in _onsubmitActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onsuspend TODO: Get Comments as metadata identification
        private bool _isOnsuspendEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onsuspendActionMap = new Dictionary<string, Func<Task>>();

        public string onsuspend(
            Func<Task> callback
        )
        {
            SetupOnsuspendLoop();

            var handle = Guid.NewGuid().ToString();
            _onsuspendActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onsuspend_Remove(
            string handle
        )
        {
            return _onsuspendActionMap.Remove(
                handle
            );
        }

        private void SetupOnsuspendLoop()
        {
            if (_isOnsuspendEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onsuspend",
                "CallOnsuspendActions",
                _invokableReference
            );
            _isOnsuspendEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnsuspendActions()
        {
            foreach (var action in _onsuspendActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ontimeupdate TODO: Get Comments as metadata identification
        private bool _isOntimeupdateEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ontimeupdateActionMap = new Dictionary<string, Func<Task>>();

        public string ontimeupdate(
            Func<Task> callback
        )
        {
            SetupOntimeupdateLoop();

            var handle = Guid.NewGuid().ToString();
            _ontimeupdateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ontimeupdate_Remove(
            string handle
        )
        {
            return _ontimeupdateActionMap.Remove(
                handle
            );
        }

        private void SetupOntimeupdateLoop()
        {
            if (_isOntimeupdateEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ontimeupdate",
                "CallOntimeupdateActions",
                _invokableReference
            );
            _isOntimeupdateEnabled = true;
        }

        [JSInvokable]
        public async Task CallOntimeupdateActions()
        {
            foreach (var action in _ontimeupdateActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ontoggle TODO: Get Comments as metadata identification
        private bool _isOntoggleEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ontoggleActionMap = new Dictionary<string, Func<Task>>();

        public string ontoggle(
            Func<Task> callback
        )
        {
            SetupOntoggleLoop();

            var handle = Guid.NewGuid().ToString();
            _ontoggleActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ontoggle_Remove(
            string handle
        )
        {
            return _ontoggleActionMap.Remove(
                handle
            );
        }

        private void SetupOntoggleLoop()
        {
            if (_isOntoggleEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ontoggle",
                "CallOntoggleActions",
                _invokableReference
            );
            _isOntoggleEnabled = true;
        }

        [JSInvokable]
        public async Task CallOntoggleActions()
        {
            foreach (var action in _ontoggleActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ontouchcancel TODO: Get Comments as metadata identification
        private bool _isOntouchcancelEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ontouchcancelActionMap = new Dictionary<string, Func<Task>>();

        public string ontouchcancel(
            Func<Task> callback
        )
        {
            SetupOntouchcancelLoop();

            var handle = Guid.NewGuid().ToString();
            _ontouchcancelActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ontouchcancel_Remove(
            string handle
        )
        {
            return _ontouchcancelActionMap.Remove(
                handle
            );
        }

        private void SetupOntouchcancelLoop()
        {
            if (_isOntouchcancelEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ontouchcancel",
                "CallOntouchcancelActions",
                _invokableReference
            );
            _isOntouchcancelEnabled = true;
        }

        [JSInvokable]
        public async Task CallOntouchcancelActions()
        {
            foreach (var action in _ontouchcancelActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ontouchend TODO: Get Comments as metadata identification
        private bool _isOntouchendEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ontouchendActionMap = new Dictionary<string, Func<Task>>();

        public string ontouchend(
            Func<Task> callback
        )
        {
            SetupOntouchendLoop();

            var handle = Guid.NewGuid().ToString();
            _ontouchendActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ontouchend_Remove(
            string handle
        )
        {
            return _ontouchendActionMap.Remove(
                handle
            );
        }

        private void SetupOntouchendLoop()
        {
            if (_isOntouchendEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ontouchend",
                "CallOntouchendActions",
                _invokableReference
            );
            _isOntouchendEnabled = true;
        }

        [JSInvokable]
        public async Task CallOntouchendActions()
        {
            foreach (var action in _ontouchendActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ontouchmove TODO: Get Comments as metadata identification
        private bool _isOntouchmoveEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ontouchmoveActionMap = new Dictionary<string, Func<Task>>();

        public string ontouchmove(
            Func<Task> callback
        )
        {
            SetupOntouchmoveLoop();

            var handle = Guid.NewGuid().ToString();
            _ontouchmoveActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ontouchmove_Remove(
            string handle
        )
        {
            return _ontouchmoveActionMap.Remove(
                handle
            );
        }

        private void SetupOntouchmoveLoop()
        {
            if (_isOntouchmoveEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ontouchmove",
                "CallOntouchmoveActions",
                _invokableReference
            );
            _isOntouchmoveEnabled = true;
        }

        [JSInvokable]
        public async Task CallOntouchmoveActions()
        {
            foreach (var action in _ontouchmoveActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ontouchstart TODO: Get Comments as metadata identification
        private bool _isOntouchstartEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ontouchstartActionMap = new Dictionary<string, Func<Task>>();

        public string ontouchstart(
            Func<Task> callback
        )
        {
            SetupOntouchstartLoop();

            var handle = Guid.NewGuid().ToString();
            _ontouchstartActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ontouchstart_Remove(
            string handle
        )
        {
            return _ontouchstartActionMap.Remove(
                handle
            );
        }

        private void SetupOntouchstartLoop()
        {
            if (_isOntouchstartEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ontouchstart",
                "CallOntouchstartActions",
                _invokableReference
            );
            _isOntouchstartEnabled = true;
        }

        [JSInvokable]
        public async Task CallOntouchstartActions()
        {
            foreach (var action in _ontouchstartActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ontransitioncancel TODO: Get Comments as metadata identification
        private bool _isOntransitioncancelEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ontransitioncancelActionMap = new Dictionary<string, Func<Task>>();

        public string ontransitioncancel(
            Func<Task> callback
        )
        {
            SetupOntransitioncancelLoop();

            var handle = Guid.NewGuid().ToString();
            _ontransitioncancelActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ontransitioncancel_Remove(
            string handle
        )
        {
            return _ontransitioncancelActionMap.Remove(
                handle
            );
        }

        private void SetupOntransitioncancelLoop()
        {
            if (_isOntransitioncancelEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ontransitioncancel",
                "CallOntransitioncancelActions",
                _invokableReference
            );
            _isOntransitioncancelEnabled = true;
        }

        [JSInvokable]
        public async Task CallOntransitioncancelActions()
        {
            foreach (var action in _ontransitioncancelActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ontransitionend TODO: Get Comments as metadata identification
        private bool _isOntransitionendEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ontransitionendActionMap = new Dictionary<string, Func<Task>>();

        public string ontransitionend(
            Func<Task> callback
        )
        {
            SetupOntransitionendLoop();

            var handle = Guid.NewGuid().ToString();
            _ontransitionendActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ontransitionend_Remove(
            string handle
        )
        {
            return _ontransitionendActionMap.Remove(
                handle
            );
        }

        private void SetupOntransitionendLoop()
        {
            if (_isOntransitionendEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ontransitionend",
                "CallOntransitionendActions",
                _invokableReference
            );
            _isOntransitionendEnabled = true;
        }

        [JSInvokable]
        public async Task CallOntransitionendActions()
        {
            foreach (var action in _ontransitionendActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ontransitionrun TODO: Get Comments as metadata identification
        private bool _isOntransitionrunEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ontransitionrunActionMap = new Dictionary<string, Func<Task>>();

        public string ontransitionrun(
            Func<Task> callback
        )
        {
            SetupOntransitionrunLoop();

            var handle = Guid.NewGuid().ToString();
            _ontransitionrunActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ontransitionrun_Remove(
            string handle
        )
        {
            return _ontransitionrunActionMap.Remove(
                handle
            );
        }

        private void SetupOntransitionrunLoop()
        {
            if (_isOntransitionrunEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ontransitionrun",
                "CallOntransitionrunActions",
                _invokableReference
            );
            _isOntransitionrunEnabled = true;
        }

        [JSInvokable]
        public async Task CallOntransitionrunActions()
        {
            foreach (var action in _ontransitionrunActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region ontransitionstart TODO: Get Comments as metadata identification
        private bool _isOntransitionstartEnabled = false;
        private readonly IDictionary<string, Func<Task>> _ontransitionstartActionMap = new Dictionary<string, Func<Task>>();

        public string ontransitionstart(
            Func<Task> callback
        )
        {
            SetupOntransitionstartLoop();

            var handle = Guid.NewGuid().ToString();
            _ontransitionstartActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool ontransitionstart_Remove(
            string handle
        )
        {
            return _ontransitionstartActionMap.Remove(
                handle
            );
        }

        private void SetupOntransitionstartLoop()
        {
            if (_isOntransitionstartEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "ontransitionstart",
                "CallOntransitionstartActions",
                _invokableReference
            );
            _isOntransitionstartEnabled = true;
        }

        [JSInvokable]
        public async Task CallOntransitionstartActions()
        {
            foreach (var action in _ontransitionstartActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onvolumechange TODO: Get Comments as metadata identification
        private bool _isOnvolumechangeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onvolumechangeActionMap = new Dictionary<string, Func<Task>>();

        public string onvolumechange(
            Func<Task> callback
        )
        {
            SetupOnvolumechangeLoop();

            var handle = Guid.NewGuid().ToString();
            _onvolumechangeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onvolumechange_Remove(
            string handle
        )
        {
            return _onvolumechangeActionMap.Remove(
                handle
            );
        }

        private void SetupOnvolumechangeLoop()
        {
            if (_isOnvolumechangeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onvolumechange",
                "CallOnvolumechangeActions",
                _invokableReference
            );
            _isOnvolumechangeEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnvolumechangeActions()
        {
            foreach (var action in _onvolumechangeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onwaiting TODO: Get Comments as metadata identification
        private bool _isOnwaitingEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onwaitingActionMap = new Dictionary<string, Func<Task>>();

        public string onwaiting(
            Func<Task> callback
        )
        {
            SetupOnwaitingLoop();

            var handle = Guid.NewGuid().ToString();
            _onwaitingActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onwaiting_Remove(
            string handle
        )
        {
            return _onwaitingActionMap.Remove(
                handle
            );
        }

        private void SetupOnwaitingLoop()
        {
            if (_isOnwaitingEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onwaiting",
                "CallOnwaitingActions",
                _invokableReference
            );
            _isOnwaitingEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnwaitingActions()
        {
            foreach (var action in _onwaitingActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onwheel TODO: Get Comments as metadata identification
        private bool _isOnwheelEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onwheelActionMap = new Dictionary<string, Func<Task>>();

        public string onwheel(
            Func<Task> callback
        )
        {
            SetupOnwheelLoop();

            var handle = Guid.NewGuid().ToString();
            _onwheelActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onwheel_Remove(
            string handle
        )
        {
            return _onwheelActionMap.Remove(
                handle
            );
        }

        private void SetupOnwheelLoop()
        {
            if (_isOnwheelEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onwheel",
                "CallOnwheelActions",
                _invokableReference
            );
            _isOnwheelEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnwheelActions()
        {
            foreach (var action in _onwheelActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void addEventListener(K type, ActionCallback<GlobalEventHandlers, K> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEventListener" }, type, listener, options
                }
            );
        }

        public void removeEventListener(K type, ActionCallback<GlobalEventHandlers, K> listener, System.Nullable<bool> options = null)
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