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

    public interface Text : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<TextCachedEntity>))]
    public class TextCachedEntity : CachedEntityObject, CharacterData, Slottable, Text
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

        
        public string wholeText
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "wholeText"
                );
            }
        }
        #endregion
        
        #region Constructor
        public TextCachedEntity() : base() { }

        public TextCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public TextCachedEntity splitText(decimal offset)
        {
            return EventHorizonBlazorInterop.FuncClass<TextCachedEntity>(
                entity => new TextCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "splitText" }, offset
                }
            );
        }
        #endregion
    }
}