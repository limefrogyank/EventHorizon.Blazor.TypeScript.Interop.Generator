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

    public interface DocumentAndElementEventHandlers : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<DocumentAndElementEventHandlersCachedEntity>))]
    public class DocumentAndElementEventHandlersCachedEntity : CachedEntityObject, DocumentAndElementEventHandlers
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
        public DocumentAndElementEventHandlersCachedEntity() : base() { }

        public DocumentAndElementEventHandlersCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        #region oncopy TODO: Get Comments as metadata identification
        private bool _isOncopyEnabled = false;
        private readonly IDictionary<string, Func<Task>> _oncopyActionMap = new Dictionary<string, Func<Task>>();

        public string oncopy(
            Func<Task> callback
        )
        {
            SetupOncopyLoop();

            var handle = Guid.NewGuid().ToString();
            _oncopyActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool oncopy_Remove(
            string handle
        )
        {
            return _oncopyActionMap.Remove(
                handle
            );
        }

        private void SetupOncopyLoop()
        {
            if (_isOncopyEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "oncopy",
                "CallOncopyActions",
                _invokableReference
            );
            _isOncopyEnabled = true;
        }

        [JSInvokable]
        public async Task CallOncopyActions()
        {
            foreach (var action in _oncopyActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region oncut TODO: Get Comments as metadata identification
        private bool _isOncutEnabled = false;
        private readonly IDictionary<string, Func<Task>> _oncutActionMap = new Dictionary<string, Func<Task>>();

        public string oncut(
            Func<Task> callback
        )
        {
            SetupOncutLoop();

            var handle = Guid.NewGuid().ToString();
            _oncutActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool oncut_Remove(
            string handle
        )
        {
            return _oncutActionMap.Remove(
                handle
            );
        }

        private void SetupOncutLoop()
        {
            if (_isOncutEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "oncut",
                "CallOncutActions",
                _invokableReference
            );
            _isOncutEnabled = true;
        }

        [JSInvokable]
        public async Task CallOncutActions()
        {
            foreach (var action in _oncutActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onpaste TODO: Get Comments as metadata identification
        private bool _isOnpasteEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onpasteActionMap = new Dictionary<string, Func<Task>>();

        public string onpaste(
            Func<Task> callback
        )
        {
            SetupOnpasteLoop();

            var handle = Guid.NewGuid().ToString();
            _onpasteActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onpaste_Remove(
            string handle
        )
        {
            return _onpasteActionMap.Remove(
                handle
            );
        }

        private void SetupOnpasteLoop()
        {
            if (_isOnpasteEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onpaste",
                "CallOnpasteActions",
                _invokableReference
            );
            _isOnpasteEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnpasteActions()
        {
            foreach (var action in _onpasteActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void addEventListener(K type, ActionCallback<DocumentAndElementEventHandlers, K> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEventListener" }, type, listener, options
                }
            );
        }

        public void removeEventListener(K type, ActionCallback<DocumentAndElementEventHandlers, K> listener, System.Nullable<bool> options = null)
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