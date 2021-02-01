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

    public interface XPathResult : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<XPathResultCachedEntity>))]
    public class XPathResultCachedEntity : CachedEntityObject, XPathResult
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
        
        public bool booleanValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "booleanValue"
                );
            }
        }

        
        public bool invalidIteratorState
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invalidIteratorState"
                );
            }
        }

        
        public decimal numberValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "numberValue"
                );
            }
        }

        
        public decimal resultType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "resultType"
                );
            }
        }

        private NodeCachedEntity __singleNodeValue;
        public NodeCachedEntity singleNodeValue
        {
            get
            {
            if(__singleNodeValue == null)
            {
                __singleNodeValue = EventHorizonBlazorInterop.GetClass<NodeCachedEntity>(
                    this.___guid,
                    "singleNodeValue",
                    (entity) =>
                    {
                        return new NodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __singleNodeValue;
            }
        }

        
        public decimal snapshotLength
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "snapshotLength"
                );
            }
        }

        
        public string stringValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "stringValue"
                );
            }
        }

        
        public decimal ANY_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ANY_TYPE"
                );
            }
        }

        
        public decimal ANY_UNORDERED_NODE_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ANY_UNORDERED_NODE_TYPE"
                );
            }
        }

        
        public decimal BOOLEAN_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BOOLEAN_TYPE"
                );
            }
        }

        
        public decimal FIRST_ORDERED_NODE_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FIRST_ORDERED_NODE_TYPE"
                );
            }
        }

        
        public decimal NUMBER_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NUMBER_TYPE"
                );
            }
        }

        
        public decimal ORDERED_NODE_ITERATOR_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ORDERED_NODE_ITERATOR_TYPE"
                );
            }
        }

        
        public decimal ORDERED_NODE_SNAPSHOT_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ORDERED_NODE_SNAPSHOT_TYPE"
                );
            }
        }

        
        public decimal STRING_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STRING_TYPE"
                );
            }
        }

        
        public decimal UNORDERED_NODE_ITERATOR_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNORDERED_NODE_ITERATOR_TYPE"
                );
            }
        }

        
        public decimal UNORDERED_NODE_SNAPSHOT_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNORDERED_NODE_SNAPSHOT_TYPE"
                );
            }
        }
        #endregion
        
        #region Constructor
        public XPathResultCachedEntity() : base() { }

        public XPathResultCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public NodeCachedEntity iterateNext()
        {
            return EventHorizonBlazorInterop.FuncClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "iterateNext" }
                }
            );
        }

        public NodeCachedEntity snapshotItem(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "snapshotItem" }, index
                }
            );
        }
        #endregion
    }
}