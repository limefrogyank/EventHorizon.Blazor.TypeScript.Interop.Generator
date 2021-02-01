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

    public interface Location : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<LocationCachedEntity>))]
    public class LocationCachedEntity : CachedEntityObject, Location
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
        private DOMStringListCachedEntity __ancestorOrigins;
        public DOMStringListCachedEntity ancestorOrigins
        {
            get
            {
            if(__ancestorOrigins == null)
            {
                __ancestorOrigins = EventHorizonBlazorInterop.GetClass<DOMStringListCachedEntity>(
                    this.___guid,
                    "ancestorOrigins",
                    (entity) =>
                    {
                        return new DOMStringListCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __ancestorOrigins;
            }
        }

        
        public string hash
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "hash"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hash",
                    value
                );
            }
        }

        
        public string host
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "host"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "host",
                    value
                );
            }
        }

        
        public string hostname
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "hostname"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hostname",
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "href",
                    value
                );
            }
        }

        
        public string origin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "origin"
                );
            }
        }

        
        public string pathname
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "pathname"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pathname",
                    value
                );
            }
        }

        
        public string port
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "port"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "port",
                    value
                );
            }
        }

        
        public string protocol
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "protocol"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "protocol",
                    value
                );
            }
        }

        
        public string search
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "search"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "search",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public LocationCachedEntity() : base() { }

        public LocationCachedEntity(
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

        public void assign(string url)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "assign" }, url
                }
            );
        }

        public void reload()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reload" }
                }
            );
        }

        public void replace(string url)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "replace" }, url
                }
            );
        }
        #endregion
    }
}