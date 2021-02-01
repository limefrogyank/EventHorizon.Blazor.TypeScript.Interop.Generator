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

    public interface CanvasText : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasTextCachedEntity>))]
    public class CanvasTextCachedEntity : CachedEntityObject, CanvasText
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
        public CanvasTextCachedEntity() : base() { }

        public CanvasTextCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void fillText(string text, decimal x, decimal y, System.Nullable<decimal> maxWidth = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fillText" }, text, x, y, maxWidth
                }
            );
        }

        public TextMetricsCachedEntity measureText(string text)
        {
            return EventHorizonBlazorInterop.FuncClass<TextMetricsCachedEntity>(
                entity => new TextMetricsCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "measureText" }, text
                }
            );
        }

        public void strokeText(string text, decimal x, decimal y, System.Nullable<decimal> maxWidth = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "strokeText" }, text, x, y, maxWidth
                }
            );
        }
        #endregion
    }
}