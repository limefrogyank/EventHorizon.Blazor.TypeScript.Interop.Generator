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

    public interface CaretPosition : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CaretPositionCachedEntity>))]
    public class CaretPositionCachedEntity : CachedEntityObject, CaretPosition
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
        
        public decimal offset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offset"
                );
            }
        }

        private NodeCachedEntity __offsetNode;
        public NodeCachedEntity offsetNode
        {
            get
            {
            if(__offsetNode == null)
            {
                __offsetNode = EventHorizonBlazorInterop.GetClass<NodeCachedEntity>(
                    this.___guid,
                    "offsetNode",
                    (entity) =>
                    {
                        return new NodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __offsetNode;
            }
        }
        #endregion
        
        #region Constructor
        public CaretPositionCachedEntity() : base() { }

        public CaretPositionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public DOMRectCachedEntity getClientRect()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMRectCachedEntity>(
                entity => new DOMRectCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getClientRect" }
                }
            );
        }
        #endregion
    }
}