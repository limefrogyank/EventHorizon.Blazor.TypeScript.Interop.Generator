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

    public interface CharacterData : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CharacterDataCachedEntity>))]
    public class CharacterDataCachedEntity : CachedEntityObject, Node, ChildNode, NonDocumentTypeChildNode, CharacterData
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
        
        public string data
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "data"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }

        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
        }

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
        #endregion
        
        #region Constructor
        public CharacterDataCachedEntity() : base() { }

        public CharacterDataCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void appendData(string data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "appendData" }, data
                }
            );
        }

        public void deleteData(decimal offset, decimal count)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteData" }, offset, count
                }
            );
        }

        public void insertData(decimal offset, string data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "insertData" }, offset, data
                }
            );
        }

        public void replaceData(decimal offset, decimal count, string data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "replaceData" }, offset, count, data
                }
            );
        }

        public string substringData(decimal offset, decimal count)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "substringData" }, offset, count
                }
            );
        }
        #endregion
    }
}