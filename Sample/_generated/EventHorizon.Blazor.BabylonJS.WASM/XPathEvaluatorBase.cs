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

    public interface XPathEvaluatorBase : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<XPathEvaluatorBaseCachedEntity>))]
    public class XPathEvaluatorBaseCachedEntity : CachedEntityObject, XPathEvaluatorBase
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
        public XPathEvaluatorBaseCachedEntity() : base() { }

        public XPathEvaluatorBaseCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public XPathExpressionCachedEntity createExpression(string expression, string resolver = null)
        {
            return EventHorizonBlazorInterop.FuncClass<XPathExpressionCachedEntity>(
                entity => new XPathExpressionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createExpression" }, expression, resolver
                }
            );
        }

        public string createNSResolver(Node nodeResolver)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "createNSResolver" }, nodeResolver
                }
            );
        }

        public XPathResultCachedEntity evaluate(string expression, Node contextNode, string resolver = null, System.Nullable<decimal> type = null, XPathResult result = null)
        {
            return EventHorizonBlazorInterop.FuncClass<XPathResultCachedEntity>(
                entity => new XPathResultCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "evaluate" }, expression, contextNode, resolver, type, result
                }
            );
        }
        #endregion
    }
}