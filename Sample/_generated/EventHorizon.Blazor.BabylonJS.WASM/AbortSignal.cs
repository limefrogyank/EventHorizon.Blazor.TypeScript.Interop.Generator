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

    public interface AbortSignal : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<AbortSignalCachedEntity>))]
    public class AbortSignalCachedEntity : CachedEntityObject, EventTarget, AbortSignal
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
        
        public bool aborted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "aborted"
                );
            }
        }
        #endregion
        
        #region Constructor
        public AbortSignalCachedEntity() : base() { }

        public AbortSignalCachedEntity(
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

        public void addEventListener(K type, ActionCallback<AbortSignal, K> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEventListener" }, type, listener, options
                }
            );
        }

        public void removeEventListener(K type, ActionCallback<AbortSignal, K> listener, System.Nullable<bool> options = null)
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