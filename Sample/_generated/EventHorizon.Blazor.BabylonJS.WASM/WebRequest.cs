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

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebRequest>))]
    public class WebRequest : CachedEntityObject, IWebRequest
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static CachedEntity CustomRequestHeaders
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    "BABYLON",
                    "WebRequest.CustomRequestHeaders"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "WebRequest.CustomRequestHeaders",
                    value
                );
            }
        }

        
        public static ActionCallback[] CustomRequestModifiers
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<ActionCallback>(
                    "BABYLON",
                    "WebRequest.CustomRequestModifiers"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "WebRequest.CustomRequestModifiers",
                    value
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public ActionCallback onprogress
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback>(
                    this.___guid,
                    "onprogress"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onprogress",
                    value
                );
            }
        }

        
        public decimal readyState
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "readyState"
                );
            }
        }

        
        public decimal status
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "status"
                );
            }
        }

        
        public string statusText
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "statusText"
                );
            }
        }

        
        public CachedEntity response
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "response"
                );
            }
        }

        
        public string responseURL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "responseURL"
                );
            }
        }

        
        public string responseText
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "responseText"
                );
            }
        }

        private XMLHttpRequestResponseType __responseType;
        public XMLHttpRequestResponseType responseType
        {
            get
            {
            if(__responseType == null)
            {
                __responseType = EventHorizonBlazorInterop.GetClass<XMLHttpRequestResponseType>(
                    this.___guid,
                    "responseType",
                    (entity) =>
                    {
                        return new XMLHttpRequestResponseType() { ___guid = entity.___guid };
                    }
                );
            }
            return __responseType;
            }
            set
            {
__responseType = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "responseType",
                    value
                );
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public WebRequest() : base() { }

        public WebRequest(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void addEventListener<K>(K type, ActionCallback<XMLHttpRequest, K> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEventListener" }, type, listener, options
                }
            );
        }

        public void removeEventListener<K>(K type, ActionCallback<XMLHttpRequest, K> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeEventListener" }, type, listener, options
                }
            );
        }

        public void abort()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "abort" }
                }
            );
        }

        public void send(Document body = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "send" }, body
                }
            );
        }

        public void open(string method, string url)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "open" }, method, url
                }
            );
        }

        public void setRequestHeader(string name, string value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRequestHeader" }, name, value
                }
            );
        }

        public string getResponseHeader(string name)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getResponseHeader" }, name
                }
            );
        }
        #endregion
    }
}