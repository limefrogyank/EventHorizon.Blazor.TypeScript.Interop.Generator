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

    public interface GetRootNodeOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<GetRootNodeOptionsCachedEntity>))]
    public class GetRootNodeOptionsCachedEntity : CachedEntityObject, GetRootNodeOptions
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
        
        public bool composed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "composed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "composed",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public GetRootNodeOptionsCachedEntity() : base() { }

        public GetRootNodeOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}