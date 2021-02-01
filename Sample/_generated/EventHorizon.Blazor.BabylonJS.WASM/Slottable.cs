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

    public interface Slottable : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<SlottableCachedEntity>))]
    public class SlottableCachedEntity : CachedEntityObject, Slottable
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
        private HTMLSlotElementCachedEntity __assignedSlot;
        public HTMLSlotElementCachedEntity assignedSlot
        {
            get
            {
            if(__assignedSlot == null)
            {
                __assignedSlot = EventHorizonBlazorInterop.GetClass<HTMLSlotElementCachedEntity>(
                    this.___guid,
                    "assignedSlot",
                    (entity) =>
                    {
                        return new HTMLSlotElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __assignedSlot;
            }
        }
        #endregion
        
        #region Constructor
        public SlottableCachedEntity() : base() { }

        public SlottableCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}