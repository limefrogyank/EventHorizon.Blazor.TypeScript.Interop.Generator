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

    public interface Selection : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<SelectionCachedEntity>))]
    public class SelectionCachedEntity : CachedEntityObject, Selection
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
        private NodeCachedEntity __anchorNode;
        public NodeCachedEntity anchorNode
        {
            get
            {
            if(__anchorNode == null)
            {
                __anchorNode = EventHorizonBlazorInterop.GetClass<NodeCachedEntity>(
                    this.___guid,
                    "anchorNode",
                    (entity) =>
                    {
                        return new NodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __anchorNode;
            }
        }

        
        public decimal anchorOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "anchorOffset"
                );
            }
        }

        private NodeCachedEntity __focusNode;
        public NodeCachedEntity focusNode
        {
            get
            {
            if(__focusNode == null)
            {
                __focusNode = EventHorizonBlazorInterop.GetClass<NodeCachedEntity>(
                    this.___guid,
                    "focusNode",
                    (entity) =>
                    {
                        return new NodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __focusNode;
            }
        }

        
        public decimal focusOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "focusOffset"
                );
            }
        }

        
        public bool isCollapsed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isCollapsed"
                );
            }
        }

        
        public decimal rangeCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rangeCount"
                );
            }
        }

        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
        }
        #endregion
        
        #region Constructor
        public SelectionCachedEntity() : base() { }

        public SelectionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void addRange(Range range)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addRange" }, range
                }
            );
        }

        public void collapse(Node node = null, System.Nullable<decimal> offset = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "collapse" }, node, offset
                }
            );
        }

        public void collapseToEnd()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "collapseToEnd" }
                }
            );
        }

        public void collapseToStart()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "collapseToStart" }
                }
            );
        }

        public bool containsNode(Node node, System.Nullable<bool> allowPartialContainment = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsNode" }, node, allowPartialContainment
                }
            );
        }

        public void deleteFromDocument()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteFromDocument" }
                }
            );
        }

        public void empty()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "empty" }
                }
            );
        }

        public void extend(Node node, System.Nullable<decimal> offset = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "extend" }, node, offset
                }
            );
        }

        public RangeCachedEntity getRangeAt(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<RangeCachedEntity>(
                entity => new RangeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRangeAt" }, index
                }
            );
        }

        public void removeAllRanges()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeAllRanges" }
                }
            );
        }

        public void removeRange(Range range)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeRange" }, range
                }
            );
        }

        public void selectAllChildren(Node node)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "selectAllChildren" }, node
                }
            );
        }

        public void setBaseAndExtent(Node anchorNode, decimal anchorOffset, Node focusNode, decimal focusOffset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBaseAndExtent" }, anchorNode, anchorOffset, focusNode, focusOffset
                }
            );
        }

        public void setPosition(Node node = null, System.Nullable<decimal> offset = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, node, offset
                }
            );
        }

        public string toString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }
        #endregion
    }
}