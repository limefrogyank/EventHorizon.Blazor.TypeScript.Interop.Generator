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

    public interface InnerHTML : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<InnerHTMLCachedEntity>))]
    public class InnerHTMLCachedEntity : CachedEntityObject, InnerHTML
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
        
        public string innerHTML
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "innerHTML"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "innerHTML",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public InnerHTMLCachedEntity() : base() { }

        public InnerHTMLCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}