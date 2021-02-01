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

    public interface CanvasPathDrawingStyles : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasPathDrawingStylesCachedEntity>))]
    public class CanvasPathDrawingStylesCachedEntity : CachedEntityObject, CanvasPathDrawingStyles
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
        
        public CachedEntity lineCap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "lineCap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineCap",
                    value
                );
            }
        }

        
        public decimal lineDashOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lineDashOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineDashOffset",
                    value
                );
            }
        }

        
        public CachedEntity lineJoin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "lineJoin"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineJoin",
                    value
                );
            }
        }

        
        public decimal lineWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lineWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineWidth",
                    value
                );
            }
        }

        
        public decimal miterLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "miterLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "miterLimit",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CanvasPathDrawingStylesCachedEntity() : base() { }

        public CanvasPathDrawingStylesCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public decimal[] getLineDash()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLineDash" }
                }
            );
        }

        public void setLineDash(decimal[] segments)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLineDash" }, segments
                }
            );
        }
        #endregion
    }
}