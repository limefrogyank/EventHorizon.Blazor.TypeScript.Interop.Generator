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

    public interface NodeListOf<TNode> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<NodeListOfCachedEntity<CachedEntity>>))]
    public class NodeListOfCachedEntity<TNode> : CachedEntityObject, NodeList, NodeListOf<TNode> where TNode : CachedEntity, new()
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
        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "length",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public NodeListOfCachedEntity() : base() { }

        public NodeListOfCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public TNode item(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<TNode>(
                entity => new TNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "item" }, index
                }
            );
        }

        public void forEach(ActionCallback<TNode, decimal, NodeListOf<TNode>> callbackfn, object thisArg = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forEach" }, callbackfn, thisArg
                }
            );
        }
        #endregion
    }
}