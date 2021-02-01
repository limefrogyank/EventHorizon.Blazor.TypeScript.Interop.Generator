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

    public interface ReadableStream<R> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ReadableStreamCachedEntity<CachedEntity>>))]
    public class ReadableStreamCachedEntity<R> : CachedEntityObject, ReadableStream<R> where R : CachedEntity, new()
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
        
        public bool locked
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "locked"
                );
            }
        }
        #endregion
        
        #region Constructor
        public ReadableStreamCachedEntity() : base() { }

        public ReadableStreamCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask cancel(object reason = null)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "cancel" }, reason
                }
            );
        }

        public ReadableStreamBYOBReaderCachedEntity getReader(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<ReadableStreamBYOBReaderCachedEntity>(
                entity => new ReadableStreamBYOBReaderCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getReader" }, options
                }
            );
        }

        public ReadableStreamCachedEntity<T> pipeThrough(object , PipeOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ReadableStreamCachedEntity<T>>(
                entity => new ReadableStreamCachedEntity<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pipeThrough" }, , options
                }
            );
        }

        public async ValueTask pipeTo(WritableStream<R> dest, PipeOptions options = null)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pipeTo" }, dest, options
                }
            );
        }

        public R tee()
        {
            return EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "tee" }
                }
            );
        }
        #endregion
    }
}