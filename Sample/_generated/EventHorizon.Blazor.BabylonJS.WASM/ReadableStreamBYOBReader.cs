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

    public interface ReadableStreamBYOBReader : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ReadableStreamBYOBReaderCachedEntity>))]
    public class ReadableStreamBYOBReaderCachedEntity : CachedEntityObject, ReadableStreamBYOBReader
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
        
        public ValueTask closed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ValueTask>(
                    this.___guid,
                    "closed"
                );
            }
        }
        #endregion
        
        #region Constructor
        public ReadableStreamBYOBReaderCachedEntity() : base() { }

        public ReadableStreamBYOBReaderCachedEntity(
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

        public ValueTask<ReadableStreamReadValueResultCachedEntity<T>> read(T view)
        {
            return EventHorizonBlazorInterop.Task<ReadableStreamReadValueResultCachedEntity<T>>(
                new object[]
                {
                    new string[] { this.___guid, "read" }, view
                }
            );
        }

        public void releaseLock()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "releaseLock" }
                }
            );
        }
        #endregion
    }
}