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

    public interface HTMLCanvasElement : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<HTMLCanvasElementCachedEntity>))]
    public class HTMLCanvasElementCachedEntity : CachedEntityObject, CachedEntity, HTMLCanvasElement
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
        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public HTMLCanvasElementCachedEntity() : base() { }

        public HTMLCanvasElementCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public CanvasRenderingContext2DCachedEntity getContext(object contextId, CanvasRenderingContext2DSettings options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasRenderingContext2DCachedEntity>(
                entity => new CanvasRenderingContext2DCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getContext" }, contextId, options
                }
            );
        }

        public void toBlob(BlobCallback callback, string type = null, object quality = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toBlob" }, callback, type, quality
                }
            );
        }

        public string toDataURL(string type = null, object quality = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toDataURL" }, type, quality
                }
            );
        }

        public OffscreenCanvasCachedEntity transferControlToOffscreen()
        {
            return EventHorizonBlazorInterop.FuncClass<OffscreenCanvasCachedEntity>(
                entity => new OffscreenCanvasCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transferControlToOffscreen" }
                }
            );
        }

        public void addEventListener(K type, ActionCallback<HTMLCanvasElement, K> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEventListener" }, type, listener, options
                }
            );
        }

        public void removeEventListener(K type, ActionCallback<HTMLCanvasElement, K> listener, System.Nullable<bool> options = null)
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