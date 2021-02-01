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

    public interface Range : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<RangeCachedEntity>))]
    public class RangeCachedEntity : CachedEntityObject, AbstractRange, Range
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
        private NodeCachedEntity __commonAncestorContainer;
        public NodeCachedEntity commonAncestorContainer
        {
            get
            {
            if(__commonAncestorContainer == null)
            {
                __commonAncestorContainer = EventHorizonBlazorInterop.GetClass<NodeCachedEntity>(
                    this.___guid,
                    "commonAncestorContainer",
                    (entity) =>
                    {
                        return new NodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __commonAncestorContainer;
            }
        }

        
        public decimal END_TO_END
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "END_TO_END"
                );
            }
        }

        
        public decimal END_TO_START
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "END_TO_START"
                );
            }
        }

        
        public decimal START_TO_END
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "START_TO_END"
                );
            }
        }

        
        public decimal START_TO_START
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "START_TO_START"
                );
            }
        }
        #endregion
        
        #region Constructor
        public RangeCachedEntity() : base() { }

        public RangeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public DocumentFragmentCachedEntity cloneContents()
        {
            return EventHorizonBlazorInterop.FuncClass<DocumentFragmentCachedEntity>(
                entity => new DocumentFragmentCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "cloneContents" }
                }
            );
        }

        public RangeCachedEntity cloneRange()
        {
            return EventHorizonBlazorInterop.FuncClass<RangeCachedEntity>(
                entity => new RangeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "cloneRange" }
                }
            );
        }

        public void collapse(System.Nullable<bool> toStart = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "collapse" }, toStart
                }
            );
        }

        public decimal compareBoundaryPoints(decimal how, Range sourceRange)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "compareBoundaryPoints" }, how, sourceRange
                }
            );
        }

        public decimal comparePoint(Node node, decimal offset)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "comparePoint" }, node, offset
                }
            );
        }

        public DocumentFragmentCachedEntity createContextualFragment(string fragment)
        {
            return EventHorizonBlazorInterop.FuncClass<DocumentFragmentCachedEntity>(
                entity => new DocumentFragmentCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createContextualFragment" }, fragment
                }
            );
        }

        public void deleteContents()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteContents" }
                }
            );
        }

        public void detach()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "detach" }
                }
            );
        }

        public DocumentFragmentCachedEntity extractContents()
        {
            return EventHorizonBlazorInterop.FuncClass<DocumentFragmentCachedEntity>(
                entity => new DocumentFragmentCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "extractContents" }
                }
            );
        }

        public DOMRectCachedEntity getBoundingClientRect()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMRectCachedEntity>(
                entity => new DOMRectCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBoundingClientRect" }
                }
            );
        }

        public DOMRectListCachedEntity getClientRects()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMRectListCachedEntity>(
                entity => new DOMRectListCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getClientRects" }
                }
            );
        }

        public void insertNode(Node node)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "insertNode" }, node
                }
            );
        }

        public bool intersectsNode(Node node)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsNode" }, node
                }
            );
        }

        public bool isPointInRange(Node node, decimal offset)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isPointInRange" }, node, offset
                }
            );
        }

        public void selectNode(Node node)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "selectNode" }, node
                }
            );
        }

        public void selectNodeContents(Node node)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "selectNodeContents" }, node
                }
            );
        }

        public void setEnd(Node node, decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEnd" }, node, offset
                }
            );
        }

        public void setEndAfter(Node node)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEndAfter" }, node
                }
            );
        }

        public void setEndBefore(Node node)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEndBefore" }, node
                }
            );
        }

        public void setStart(Node node, decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setStart" }, node, offset
                }
            );
        }

        public void setStartAfter(Node node)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setStartAfter" }, node
                }
            );
        }

        public void setStartBefore(Node node)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setStartBefore" }, node
                }
            );
        }

        public void surroundContents(Node newParent)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "surroundContents" }, newParent
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