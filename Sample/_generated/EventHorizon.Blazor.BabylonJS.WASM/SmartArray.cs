/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class SmartArray<T> : CachedEntityObject, ISmartArrayLike<T> where T : CachedEntity, new()
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
        
        public T[] data
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<T>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }

        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "length",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SmartArray() : base() { }

        public SmartArray(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SmartArray(
            decimal capacity
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "SmartArray" },
                capacity
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void push(T value)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "push" }, value
                }
            );
        }

        #region forEach TODO: Get Comments as metadata identification
        private bool _isForEachEnabled = false;
        private readonly IDictionary<string, Func<Task>> _forEachActionMap = new Dictionary<string, Func<Task>>();

        public string forEach(
            Func<Task> callback
        )
        {
            SetupForEachLoop();

            var handle = Guid.NewGuid().ToString();
            _forEachActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupForEachLoop()
        {
            if (_isForEachEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "forEach",
                "CallForEachActions",
                _invokableReference
            );
            _isForEachEnabled = true;
        }

        [JSInvokable]
        public async Task CallForEachActions()
        {
            foreach (var action in _forEachActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region sort TODO: Get Comments as metadata identification
        private bool _isSortEnabled = false;
        private readonly IDictionary<string, Func<Task>> _sortActionMap = new Dictionary<string, Func<Task>>();

        public string sort(
            Func<Task> callback
        )
        {
            SetupSortLoop();

            var handle = Guid.NewGuid().ToString();
            _sortActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupSortLoop()
        {
            if (_isSortEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "sort",
                "CallSortActions",
                _invokableReference
            );
            _isSortEnabled = true;
        }

        [JSInvokable]
        public async Task CallSortActions()
        {
            foreach (var action in _sortActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void reset()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public void concat(object array)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "concat" }, array
                }
            );
        }

        public decimal indexOf(T value)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "indexOf" }, value
                }
            );
        }

        public bool contains(T value)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "contains" }, value
                }
            );
        }
        #endregion
    }
}