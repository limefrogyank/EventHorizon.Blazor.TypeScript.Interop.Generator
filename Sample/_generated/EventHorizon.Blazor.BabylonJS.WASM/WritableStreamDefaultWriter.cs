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

    public interface WritableStreamDefaultWriter<W> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<WritableStreamDefaultWriterCachedEntity<CachedEntity>>))]
    public class WritableStreamDefaultWriterCachedEntity<W> : CachedEntityObject, WritableStreamDefaultWriter<W> where W : CachedEntity, new()
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

        
        public decimal desiredSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "desiredSize"
                );
            }
        }

        
        public ValueTask ready
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ValueTask>(
                    this.___guid,
                    "ready"
                );
            }
        }
        #endregion
        
        #region Constructor
        public WritableStreamDefaultWriterCachedEntity() : base() { }

        public WritableStreamDefaultWriterCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask abort(object reason = null)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "abort" }, reason
                }
            );
        }

        public async ValueTask close()
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "close" }
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

        public async ValueTask write(W chunk)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "write" }, chunk
                }
            );
        }
        #endregion
    }
}