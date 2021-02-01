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

    public interface Blob : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<BlobCachedEntity>))]
    public class BlobCachedEntity : CachedEntityObject, Blob
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
        
        public decimal size
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
            }
        }

        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
        }
        #endregion
        
        #region Constructor
        public BlobCachedEntity() : base() { }

        public BlobCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ValueTask<ArrayBuffer> arrayBuffer()
        {
            return EventHorizonBlazorInterop.TaskClass<ArrayBuffer>(
                entity => new ArrayBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "arrayBuffer" }
                }
            );
        }

        public BlobCachedEntity slice(System.Nullable<decimal> start = null, System.Nullable<decimal> end = null, string contentType = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BlobCachedEntity>(
                entity => new BlobCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "slice" }, start, end, contentType
                }
            );
        }

        public ReadableStreamCachedEntity stream()
        {
            return EventHorizonBlazorInterop.FuncClass<ReadableStreamCachedEntity>(
                entity => new ReadableStreamCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stream" }
                }
            );
        }

        public ValueTask<string> text()
        {
            return EventHorizonBlazorInterop.Task<string>(
                new object[]
                {
                    new string[] { this.___guid, "text" }
                }
            );
        }
        #endregion
    }
}