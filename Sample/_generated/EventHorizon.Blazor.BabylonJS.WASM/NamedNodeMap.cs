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

    public interface NamedNodeMap : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<NamedNodeMapCachedEntity>))]
    public class NamedNodeMapCachedEntity : CachedEntityObject, NamedNodeMap
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
        #endregion
        
        #region Constructor
        public NamedNodeMapCachedEntity() : base() { }

        public NamedNodeMapCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public AttrCachedEntity getNamedItem(string qualifiedName)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getNamedItem" }, qualifiedName
                }
            );
        }

        public AttrCachedEntity getNamedItemNS(string localName, string namespace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getNamedItemNS" }, namespace, localName
                }
            );
        }

        public AttrCachedEntity item(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "item" }, index
                }
            );
        }

        public AttrCachedEntity removeNamedItem(string qualifiedName)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeNamedItem" }, qualifiedName
                }
            );
        }

        public AttrCachedEntity removeNamedItemNS(string localName, string namespace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeNamedItemNS" }, namespace, localName
                }
            );
        }

        public AttrCachedEntity setNamedItem(Attr attr)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setNamedItem" }, attr
                }
            );
        }

        public AttrCachedEntity setNamedItemNS(Attr attr)
        {
            return EventHorizonBlazorInterop.FuncClass<AttrCachedEntity>(
                entity => new AttrCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setNamedItemNS" }, attr
                }
            );
        }
        #endregion
    }
}