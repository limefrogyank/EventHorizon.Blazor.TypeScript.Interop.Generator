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

    public interface TextMetrics : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<TextMetricsCachedEntity>))]
    public class TextMetricsCachedEntity : CachedEntityObject, TextMetrics
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
        
        public decimal actualBoundingBoxAscent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "actualBoundingBoxAscent"
                );
            }
        }

        
        public decimal actualBoundingBoxDescent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "actualBoundingBoxDescent"
                );
            }
        }

        
        public decimal actualBoundingBoxLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "actualBoundingBoxLeft"
                );
            }
        }

        
        public decimal actualBoundingBoxRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "actualBoundingBoxRight"
                );
            }
        }

        
        public decimal alphabeticBaseline
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphabeticBaseline"
                );
            }
        }

        
        public decimal emHeightAscent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "emHeightAscent"
                );
            }
        }

        
        public decimal emHeightDescent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "emHeightDescent"
                );
            }
        }

        
        public decimal fontBoundingBoxAscent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fontBoundingBoxAscent"
                );
            }
        }

        
        public decimal fontBoundingBoxDescent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fontBoundingBoxDescent"
                );
            }
        }

        
        public decimal hangingBaseline
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "hangingBaseline"
                );
            }
        }

        
        public decimal ideographicBaseline
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ideographicBaseline"
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
        }
        #endregion
        
        #region Constructor
        public TextMetricsCachedEntity() : base() { }

        public TextMetricsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}