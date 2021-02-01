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

    public interface CanvasShadowStyles : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasShadowStylesCachedEntity>))]
    public class CanvasShadowStylesCachedEntity : CachedEntityObject, CanvasShadowStyles
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
        
        public decimal shadowBlur
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowBlur"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowBlur",
                    value
                );
            }
        }

        
        public string shadowColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "shadowColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowColor",
                    value
                );
            }
        }

        
        public decimal shadowOffsetX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowOffsetX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowOffsetX",
                    value
                );
            }
        }

        
        public decimal shadowOffsetY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowOffsetY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowOffsetY",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CanvasShadowStylesCachedEntity() : base() { }

        public CanvasShadowStylesCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}