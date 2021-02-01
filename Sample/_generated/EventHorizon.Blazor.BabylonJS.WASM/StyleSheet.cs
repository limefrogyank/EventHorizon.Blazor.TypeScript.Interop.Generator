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

    public interface StyleSheet : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<StyleSheetCachedEntity>))]
    public class StyleSheetCachedEntity : CachedEntityObject, StyleSheet
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
        
        public bool disabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disabled",
                    value
                );
            }
        }

        
        public string href
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "href"
                );
            }
        }

        private MediaListCachedEntity __media;
        public MediaListCachedEntity media
        {
            get
            {
            if(__media == null)
            {
                __media = EventHorizonBlazorInterop.GetClass<MediaListCachedEntity>(
                    this.___guid,
                    "media",
                    (entity) =>
                    {
                        return new MediaListCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __media;
            }
        }

        private ElementCachedEntity __ownerNode;
        public ElementCachedEntity ownerNode
        {
            get
            {
            if(__ownerNode == null)
            {
                __ownerNode = EventHorizonBlazorInterop.GetClass<ElementCachedEntity>(
                    this.___guid,
                    "ownerNode",
                    (entity) =>
                    {
                        return new ElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __ownerNode;
            }
        }

        private CSSStyleSheetCachedEntity __parentStyleSheet;
        public CSSStyleSheetCachedEntity parentStyleSheet
        {
            get
            {
            if(__parentStyleSheet == null)
            {
                __parentStyleSheet = EventHorizonBlazorInterop.GetClass<CSSStyleSheetCachedEntity>(
                    this.___guid,
                    "parentStyleSheet",
                    (entity) =>
                    {
                        return new CSSStyleSheetCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __parentStyleSheet;
            }
        }

        
        public string title
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "title"
                );
            }
        }

        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
        }
        #endregion
        
        #region Constructor
        public StyleSheetCachedEntity() : base() { }

        public StyleSheetCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}