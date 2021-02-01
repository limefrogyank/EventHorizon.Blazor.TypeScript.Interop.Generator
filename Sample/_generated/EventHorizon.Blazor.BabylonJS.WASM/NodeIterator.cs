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

    public interface NodeIterator : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<NodeIteratorCachedEntity>))]
    public class NodeIteratorCachedEntity : CachedEntityObject, NodeIterator
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
        private NodeFilterCachedEntity __filter;
        public NodeFilterCachedEntity filter
        {
            get
            {
            if(__filter == null)
            {
                __filter = EventHorizonBlazorInterop.GetClass<NodeFilterCachedEntity>(
                    this.___guid,
                    "filter",
                    (entity) =>
                    {
                        return new NodeFilterCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __filter;
            }
        }

        
        public bool pointerBeforeReferenceNode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "pointerBeforeReferenceNode"
                );
            }
        }

        private NodeCachedEntity __referenceNode;
        public NodeCachedEntity referenceNode
        {
            get
            {
            if(__referenceNode == null)
            {
                __referenceNode = EventHorizonBlazorInterop.GetClass<NodeCachedEntity>(
                    this.___guid,
                    "referenceNode",
                    (entity) =>
                    {
                        return new NodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __referenceNode;
            }
        }

        private NodeCachedEntity __root;
        public NodeCachedEntity root
        {
            get
            {
            if(__root == null)
            {
                __root = EventHorizonBlazorInterop.GetClass<NodeCachedEntity>(
                    this.___guid,
                    "root",
                    (entity) =>
                    {
                        return new NodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __root;
            }
        }

        
        public decimal whatToShow
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "whatToShow"
                );
            }
        }
        #endregion
        
        #region Constructor
        public NodeIteratorCachedEntity() : base() { }

        public NodeIteratorCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void detach()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "detach" }
                }
            );
        }

        public NodeCachedEntity nextNode()
        {
            return EventHorizonBlazorInterop.FuncClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "nextNode" }
                }
            );
        }

        public NodeCachedEntity previousNode()
        {
            return EventHorizonBlazorInterop.FuncClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "previousNode" }
                }
            );
        }
        #endregion
    }
}