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

    public interface NodeList : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<NodeListCachedEntity>))]
    public class NodeListCachedEntity : CachedEntityObject, NodeList
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
        }
        #endregion
        
        #region Constructor
        public NodeListCachedEntity() : base() { }

        public NodeListCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public NodeCachedEntity item(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "item" }, index
                }
            );
        }

        public void forEach(ActionCallback<Node, decimal, NodeList> callbackfn, object thisArg = null)
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