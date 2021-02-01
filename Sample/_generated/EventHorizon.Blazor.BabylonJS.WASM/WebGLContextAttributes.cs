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

    public interface WebGLContextAttributes : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<WebGLContextAttributesCachedEntity>))]
    public class WebGLContextAttributesCachedEntity : CachedEntityObject, WebGLContextAttributes
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
        
        public bool alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
        public bool antialias
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "antialias"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "antialias",
                    value
                );
            }
        }

        
        public bool depth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "depth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depth",
                    value
                );
            }
        }

        
        public bool desynchronized
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "desynchronized"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "desynchronized",
                    value
                );
            }
        }

        
        public bool failIfMajorPerformanceCaveat
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "failIfMajorPerformanceCaveat"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "failIfMajorPerformanceCaveat",
                    value
                );
            }
        }

        
        public CachedEntity powerPreference
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "powerPreference"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "powerPreference",
                    value
                );
            }
        }

        
        public bool premultipliedAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "premultipliedAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "premultipliedAlpha",
                    value
                );
            }
        }

        
        public bool preserveDrawingBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preserveDrawingBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preserveDrawingBuffer",
                    value
                );
            }
        }

        
        public bool stencil
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "stencil"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencil",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public WebGLContextAttributesCachedEntity() : base() { }

        public WebGLContextAttributesCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}