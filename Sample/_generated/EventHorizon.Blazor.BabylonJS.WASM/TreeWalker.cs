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

    public interface TreeWalker : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<TreeWalkerCachedEntity>))]
    public class TreeWalkerCachedEntity : CachedEntityObject, TreeWalker
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
        private NodeCachedEntity __currentNode;
        public NodeCachedEntity currentNode
        {
            get
            {
            if(__currentNode == null)
            {
                __currentNode = EventHorizonBlazorInterop.GetClass<NodeCachedEntity>(
                    this.___guid,
                    "currentNode",
                    (entity) =>
                    {
                        return new NodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentNode;
            }
            set
            {
__currentNode = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentNode",
                    value
                );
            }
        }

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
        public TreeWalkerCachedEntity() : base() { }

        public TreeWalkerCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public NodeCachedEntity firstChild()
        {
            return EventHorizonBlazorInterop.FuncClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "firstChild" }
                }
            );
        }

        public NodeCachedEntity lastChild()
        {
            return EventHorizonBlazorInterop.FuncClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lastChild" }
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

        public NodeCachedEntity nextSibling()
        {
            return EventHorizonBlazorInterop.FuncClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "nextSibling" }
                }
            );
        }

        public NodeCachedEntity parentNode()
        {
            return EventHorizonBlazorInterop.FuncClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parentNode" }
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

        public NodeCachedEntity previousSibling()
        {
            return EventHorizonBlazorInterop.FuncClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "previousSibling" }
                }
            );
        }
        #endregion
    }
}