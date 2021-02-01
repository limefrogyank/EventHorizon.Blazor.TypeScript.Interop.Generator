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

    public interface ParentNode : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ParentNodeCachedEntity>))]
    public class ParentNodeCachedEntity : CachedEntityObject, ParentNode
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
        
        public decimal childElementCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "childElementCount"
                );
            }
        }

        private HTMLCollectionCachedEntity __children;
        public HTMLCollectionCachedEntity children
        {
            get
            {
            if(__children == null)
            {
                __children = EventHorizonBlazorInterop.GetClass<HTMLCollectionCachedEntity>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new HTMLCollectionCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __children;
            }
        }

        private ElementCachedEntity __firstElementChild;
        public ElementCachedEntity firstElementChild
        {
            get
            {
            if(__firstElementChild == null)
            {
                __firstElementChild = EventHorizonBlazorInterop.GetClass<ElementCachedEntity>(
                    this.___guid,
                    "firstElementChild",
                    (entity) =>
                    {
                        return new ElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __firstElementChild;
            }
        }

        private ElementCachedEntity __lastElementChild;
        public ElementCachedEntity lastElementChild
        {
            get
            {
            if(__lastElementChild == null)
            {
                __lastElementChild = EventHorizonBlazorInterop.GetClass<ElementCachedEntity>(
                    this.___guid,
                    "lastElementChild",
                    (entity) =>
                    {
                        return new ElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __lastElementChild;
            }
        }
        #endregion
        
        #region Constructor
        public ParentNodeCachedEntity() : base() { }

        public ParentNodeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void append(Node nodes)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "append" }, nodes
                }
            );
        }

        public void prepend(Node nodes)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepend" }, nodes
                }
            );
        }

        public K querySelector(K selectors)
        {
            return EventHorizonBlazorInterop.FuncClass<K>(
                entity => new K() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "querySelector" }, selectors
                }
            );
        }

        public NodeListOfCachedEntity<K> querySelectorAll(K selectors)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeListOfCachedEntity<K>>(
                entity => new NodeListOfCachedEntity<K>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "querySelectorAll" }, selectors
                }
            );
        }
        #endregion
    }
}