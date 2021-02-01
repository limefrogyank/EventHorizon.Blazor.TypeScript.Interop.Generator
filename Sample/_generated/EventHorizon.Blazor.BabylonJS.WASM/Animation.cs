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

    public interface Animation : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationCachedEntity>))]
    public class AnimationCachedEntity : CachedEntityObject, EventTarget, Animation
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
        
        public decimal currentTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentTime",
                    value
                );
            }
        }

        private AnimationEffectCachedEntity __effect;
        public AnimationEffectCachedEntity effect
        {
            get
            {
            if(__effect == null)
            {
                __effect = EventHorizonBlazorInterop.GetClass<AnimationEffectCachedEntity>(
                    this.___guid,
                    "effect",
                    (entity) =>
                    {
                        return new AnimationEffectCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __effect;
            }
            set
            {
__effect = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "effect",
                    value
                );
            }
        }

        private ValueTask<AnimationCachedEntity> __finished;
        public ValueTask<AnimationCachedEntity> finished
        {
            get
            {
            if(__finished == null)
            {
                __finished = EventHorizonBlazorInterop.GetClass<AnimationCachedEntity>(
                    this.___guid,
                    "finished",
                    (entity) =>
                    {
                        return new AnimationCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __finished;
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

        
        public bool pending
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "pending"
                );
            }
        }

        
        public CachedEntity playState
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "playState"
                );
            }
        }

        
        public decimal playbackRate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "playbackRate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "playbackRate",
                    value
                );
            }
        }

        private ValueTask<AnimationCachedEntity> __ready;
        public ValueTask<AnimationCachedEntity> ready
        {
            get
            {
            if(__ready == null)
            {
                __ready = EventHorizonBlazorInterop.GetClass<AnimationCachedEntity>(
                    this.___guid,
                    "ready",
                    (entity) =>
                    {
                        return new AnimationCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __ready;
            }
        }

        
        public decimal startTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "startTime",
                    value
                );
            }
        }

        private AnimationTimelineCachedEntity __timeline;
        public AnimationTimelineCachedEntity timeline
        {
            get
            {
            if(__timeline == null)
            {
                __timeline = EventHorizonBlazorInterop.GetClass<AnimationTimelineCachedEntity>(
                    this.___guid,
                    "timeline",
                    (entity) =>
                    {
                        return new AnimationTimelineCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __timeline;
            }
            set
            {
__timeline = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeline",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AnimationCachedEntity() : base() { }

        public AnimationCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
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

        #region onfinish TODO: Get Comments as metadata identification
        private bool _isOnfinishEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onfinishActionMap = new Dictionary<string, Func<Task>>();

        public string onfinish(
            Func<Task> callback
        )
        {
            SetupOnfinishLoop();

            var handle = Guid.NewGuid().ToString();
            _onfinishActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onfinish_Remove(
            string handle
        )
        {
            return _onfinishActionMap.Remove(
                handle
            );
        }

        private void SetupOnfinishLoop()
        {
            if (_isOnfinishEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onfinish",
                "CallOnfinishActions",
                _invokableReference
            );
            _isOnfinishEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnfinishActions()
        {
            foreach (var action in _onfinishActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void cancel()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "cancel" }
                }
            );
        }

        public void finish()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "finish" }
                }
            );
        }

        public void pause()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public void play()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "play" }
                }
            );
        }

        public void reverse()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reverse" }
                }
            );
        }

        public void updatePlaybackRate(decimal playbackRate)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updatePlaybackRate" }, playbackRate
                }
            );
        }

        public void addEventListener(K type, ActionCallback<Animation, K> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEventListener" }, type, listener, options
                }
            );
        }

        public void removeEventListener(K type, ActionCallback<Animation, K> listener, System.Nullable<bool> options = null)
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