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

    public interface ProcessingInstruction : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ProcessingInstructionCachedEntity>))]
    public class ProcessingInstructionCachedEntity : CachedEntityObject, CharacterData, LinkStyle, ProcessingInstruction
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
        private DocumentCachedEntity __ownerDocument;
        public DocumentCachedEntity ownerDocument
        {
            get
            {
            if(__ownerDocument == null)
            {
                __ownerDocument = EventHorizonBlazorInterop.GetClass<DocumentCachedEntity>(
                    this.___guid,
                    "ownerDocument",
                    (entity) =>
                    {
                        return new DocumentCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __ownerDocument;
            }
        }

        
        public string target
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "target"
                );
            }
        }
        #endregion
        
        #region Constructor
        public ProcessingInstructionCachedEntity() : base() { }

        public ProcessingInstructionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}