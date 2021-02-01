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

    public interface ReadableStreamReadValueResult<T> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ReadableStreamReadValueResultCachedEntity<CachedEntity>>))]
    public class ReadableStreamReadValueResultCachedEntity<T> : CachedEntityObject, ReadableStreamReadValueResult<T> where T : CachedEntity, new()
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
        
        public CachedEntity done
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "done",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "done",
                    value
                );
            }
        }

        private T __value;
        public T value
        {
            get
            {
            if(__value == null)
            {
                __value = EventHorizonBlazorInterop.GetClass<T>(
                    this.___guid,
                    "value",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
                    }
                );
            }
            return __value;
            }
            set
            {
__value = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "value",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ReadableStreamReadValueResultCachedEntity() : base() { }

        public ReadableStreamReadValueResultCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}