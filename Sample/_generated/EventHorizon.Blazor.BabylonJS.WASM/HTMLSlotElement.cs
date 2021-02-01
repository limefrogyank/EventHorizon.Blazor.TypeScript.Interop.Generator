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

    public interface HTMLSlotElement : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<HTMLSlotElementCachedEntity>))]
    public class HTMLSlotElementCachedEntity : CachedEntityObject, CachedEntity, HTMLSlotElement
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public HTMLSlotElementCachedEntity() : base() { }

        public HTMLSlotElementCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ElementCachedEntity[] assignedElements(AssignedNodesOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<ElementCachedEntity>(
                entity => new ElementCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "assignedElements" }, options
                }
            );
        }

        public NodeCachedEntity[] assignedNodes(AssignedNodesOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<NodeCachedEntity>(
                entity => new NodeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "assignedNodes" }, options
                }
            );
        }

        public void addEventListener(K type, ActionCallback<HTMLSlotElement, K> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEventListener" }, type, listener, options
                }
            );
        }

        public void removeEventListener(K type, ActionCallback<HTMLSlotElement, K> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeEventListener" }, type, listener, options
                }
            );
        }
        #endregion
    }
}