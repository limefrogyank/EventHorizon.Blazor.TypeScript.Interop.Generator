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

    public interface CSSRuleList : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CSSRuleListCachedEntity>))]
    public class CSSRuleListCachedEntity : CachedEntityObject, CSSRuleList
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
        public CSSRuleListCachedEntity() : base() { }

        public CSSRuleListCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public CSSRuleCachedEntity item(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<CSSRuleCachedEntity>(
                entity => new CSSRuleCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "item" }, index
                }
            );
        }
        #endregion
    }
}