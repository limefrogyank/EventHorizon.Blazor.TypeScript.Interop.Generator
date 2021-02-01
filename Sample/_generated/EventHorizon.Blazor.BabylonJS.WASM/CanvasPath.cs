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

    public interface CanvasPath : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasPathCachedEntity>))]
    public class CanvasPathCachedEntity : CachedEntityObject, CanvasPath
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

        #endregion
        
        #region Constructor
        public CanvasPathCachedEntity() : base() { }

        public CanvasPathCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void arc(decimal x, decimal y, decimal radius, decimal startAngle, decimal endAngle, System.Nullable<bool> anticlockwise = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "arc" }, x, y, radius, startAngle, endAngle, anticlockwise
                }
            );
        }

        public void arcTo(decimal x1, decimal y1, decimal x2, decimal y2, decimal radius)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "arcTo" }, x1, y1, x2, y2, radius
                }
            );
        }

        public void bezierCurveTo(decimal cp1x, decimal cp1y, decimal cp2x, decimal cp2y, decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bezierCurveTo" }, cp1x, cp1y, cp2x, cp2y, x, y
                }
            );
        }

        public void closePath()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "closePath" }
                }
            );
        }

        public void ellipse(decimal x, decimal y, decimal radiusX, decimal radiusY, decimal rotation, decimal startAngle, decimal endAngle, System.Nullable<bool> anticlockwise = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "ellipse" }, x, y, radiusX, radiusY, rotation, startAngle, endAngle, anticlockwise
                }
            );
        }

        public void lineTo(decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "lineTo" }, x, y
                }
            );
        }

        public void moveTo(decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "moveTo" }, x, y
                }
            );
        }

        public void quadraticCurveTo(decimal cpx, decimal cpy, decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "quadraticCurveTo" }, cpx, cpy, x, y
                }
            );
        }

        public void rect(decimal x, decimal y, decimal w, decimal h)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rect" }, x, y, w, h
                }
            );
        }
        #endregion
    }
}