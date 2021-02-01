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

    public interface DOMTokenList : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<DOMTokenListCachedEntity>))]
    public class DOMTokenListCachedEntity : CachedEntityObject, DOMTokenList
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

        
        public string value
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "value"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "value",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public DOMTokenListCachedEntity() : base() { }

        public DOMTokenListCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public string toString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }

        public void add(string[] tokens)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "add" }, tokens
                }
            );
        }

        public bool contains(string token)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "contains" }, token
                }
            );
        }

        public string item(decimal index)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "item" }, index
                }
            );
        }

        public void remove(string[] tokens)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "remove" }, tokens
                }
            );
        }

        public void replace(string oldToken, string newToken)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "replace" }, oldToken, newToken
                }
            );
        }

        public bool supports(string token)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "supports" }, token
                }
            );
        }

        public bool toggle(string token, System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "toggle" }, token, force
                }
            );
        }

        public void forEach(ActionCallback<string, decimal, DOMTokenList> callbackfn, object thisArg = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forEach" }, callbackfn, thisArg
                }
            );
        }
        #endregion
    }
}