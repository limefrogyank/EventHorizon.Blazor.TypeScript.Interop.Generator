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

    public interface NodeFilter : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<NodeFilterCachedEntity>))]
    public class NodeFilterCachedEntity : CachedEntityObject, NodeFilter
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

        #endregion
        
        #region Constructor
        public NodeFilterCachedEntity() : base() { }

        public NodeFilterCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public decimal acceptNode(Node node)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "acceptNode" }, node
                }
            );
        }
        #endregion
    }
}