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

    public interface CSSRule : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CSSRuleCachedEntity>))]
    public class CSSRuleCachedEntity : CachedEntityObject, CSSRule
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
        
        public string cssText
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "cssText"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cssText",
                    value
                );
            }
        }

        private CSSRuleCachedEntity __parentRule;
        public CSSRuleCachedEntity parentRule
        {
            get
            {
            if(__parentRule == null)
            {
                __parentRule = EventHorizonBlazorInterop.GetClass<CSSRuleCachedEntity>(
                    this.___guid,
                    "parentRule",
                    (entity) =>
                    {
                        return new CSSRuleCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __parentRule;
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

        
        public decimal type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "type"
                );
            }
        }

        
        public decimal CHARSET_RULE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CHARSET_RULE"
                );
            }
        }

        
        public decimal FONT_FACE_RULE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FONT_FACE_RULE"
                );
            }
        }

        
        public decimal IMPORT_RULE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "IMPORT_RULE"
                );
            }
        }

        
        public decimal KEYFRAMES_RULE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "KEYFRAMES_RULE"
                );
            }
        }

        
        public decimal KEYFRAME_RULE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "KEYFRAME_RULE"
                );
            }
        }

        
        public decimal MEDIA_RULE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MEDIA_RULE"
                );
            }
        }

        
        public decimal NAMESPACE_RULE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NAMESPACE_RULE"
                );
            }
        }

        
        public decimal PAGE_RULE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "PAGE_RULE"
                );
            }
        }

        
        public decimal STYLE_RULE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STYLE_RULE"
                );
            }
        }

        
        public decimal SUPPORTS_RULE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SUPPORTS_RULE"
                );
            }
        }
        #endregion
        
        #region Constructor
        public CSSRuleCachedEntity() : base() { }

        public CSSRuleCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}