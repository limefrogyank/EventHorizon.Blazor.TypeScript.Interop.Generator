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

    public interface WritableStream<W> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<WritableStreamCachedEntity<CachedEntity>>))]
    public class WritableStreamCachedEntity<W> : CachedEntityObject, WritableStream<W> where W : CachedEntity, new()
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
        public WritableStreamCachedEntity() : base() { }

        public WritableStreamCachedEntity(
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

        public WritableStreamDefaultWriterCachedEntity<W> getWriter()
        {
            return EventHorizonBlazorInterop.FuncClass<WritableStreamDefaultWriterCachedEntity<W>>(
                entity => new WritableStreamDefaultWriterCachedEntity<W>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWriter" }
                }
            );
        }
        #endregion
    }
}