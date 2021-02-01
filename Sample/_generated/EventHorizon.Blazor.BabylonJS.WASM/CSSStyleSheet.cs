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

    public interface CSSStyleSheet : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CSSStyleSheetCachedEntity>))]
    public class CSSStyleSheetCachedEntity : CachedEntityObject, StyleSheet, CSSStyleSheet
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
        private CSSRuleListCachedEntity __cssRules;
        public CSSRuleListCachedEntity cssRules
        {
            get
            {
            if(__cssRules == null)
            {
                __cssRules = EventHorizonBlazorInterop.GetClass<CSSRuleListCachedEntity>(
                    this.___guid,
                    "cssRules",
                    (entity) =>
                    {
                        return new CSSRuleListCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __cssRules;
            }
        }

        private CSSRuleCachedEntity __ownerRule;
        public CSSRuleCachedEntity ownerRule
        {
            get
            {
            if(__ownerRule == null)
            {
                __ownerRule = EventHorizonBlazorInterop.GetClass<CSSRuleCachedEntity>(
                    this.___guid,
                    "ownerRule",
                    (entity) =>
                    {
                        return new CSSRuleCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __ownerRule;
            }
        }

        private CSSRuleListCachedEntity __rules;
        public CSSRuleListCachedEntity rules
        {
            get
            {
            if(__rules == null)
            {
                __rules = EventHorizonBlazorInterop.GetClass<CSSRuleListCachedEntity>(
                    this.___guid,
                    "rules",
                    (entity) =>
                    {
                        return new CSSRuleListCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __rules;
            }
        }
        #endregion
        
        #region Constructor
        public CSSStyleSheetCachedEntity() : base() { }

        public CSSStyleSheetCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public decimal addRule(string selector = null, string style = null, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "addRule" }, selector, style, index
                }
            );
        }

        public void deleteRule(decimal index)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteRule" }, index
                }
            );
        }

        public decimal insertRule(string rule, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "insertRule" }, rule, index
                }
            );
        }

        public void removeRule(System.Nullable<decimal> index = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeRule" }, index
                }
            );
        }
        #endregion
    }
}