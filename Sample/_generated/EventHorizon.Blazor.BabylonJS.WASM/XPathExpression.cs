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

    public interface XPathExpression : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<XPathExpressionCachedEntity>))]
    public class XPathExpressionCachedEntity : CachedEntityObject, XPathExpression
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
        public XPathExpressionCachedEntity() : base() { }

        public XPathExpressionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public XPathResultCachedEntity evaluate(Node contextNode, System.Nullable<decimal> type = null, XPathResult result = null)
        {
            return EventHorizonBlazorInterop.FuncClass<XPathResultCachedEntity>(
                entity => new XPathResultCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "evaluate" }, contextNode, type, result
                }
            );
        }
        #endregion
    }
}