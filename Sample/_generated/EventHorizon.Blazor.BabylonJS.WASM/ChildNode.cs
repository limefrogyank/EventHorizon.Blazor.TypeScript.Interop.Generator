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

    public interface ChildNode : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ChildNodeCachedEntity>))]
    public class ChildNodeCachedEntity : CachedEntityObject, Node, ChildNode
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
        public ChildNodeCachedEntity() : base() { }

        public ChildNodeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void after(Node nodes)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "after" }, nodes
                }
            );
        }

        public void before(Node nodes)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "before" }, nodes
                }
            );
        }

        public void remove()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "remove" }
                }
            );
        }

        public void replaceWith(Node nodes)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "replaceWith" }, nodes
                }
            );
        }
        #endregion
    }
}