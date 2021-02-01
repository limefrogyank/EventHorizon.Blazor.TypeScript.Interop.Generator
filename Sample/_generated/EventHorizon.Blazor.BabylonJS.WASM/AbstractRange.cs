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

    public interface AbstractRange : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<AbstractRangeCachedEntity>))]
    public class AbstractRangeCachedEntity : CachedEntityObject, AbstractRange
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
        
        public bool collapsed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collapsed"
                );
            }
        }

        private NodeCachedEntity __endContainer;
        public NodeCachedEntity endContainer
        {
            get
            {
            if(__endContainer == null)
            {
                __endContainer = EventHorizonBlazorInterop.GetClass<NodeCachedEntity>(
                    this.___guid,
                    "endContainer",
                    (entity) =>
                    {
                        return new NodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __endContainer;
            }
        }

        
        public decimal endOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "endOffset"
                );
            }
        }

        private NodeCachedEntity __startContainer;
        public NodeCachedEntity startContainer
        {
            get
            {
            if(__startContainer == null)
            {
                __startContainer = EventHorizonBlazorInterop.GetClass<NodeCachedEntity>(
                    this.___guid,
                    "startContainer",
                    (entity) =>
                    {
                        return new NodeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __startContainer;
            }
        }

        
        public decimal startOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startOffset"
                );
            }
        }
        #endregion
        
        #region Constructor
        public AbstractRangeCachedEntity() : base() { }

        public AbstractRangeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}