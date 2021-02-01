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

    public interface AssignedNodesOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<AssignedNodesOptionsCachedEntity>))]
    public class AssignedNodesOptionsCachedEntity : CachedEntityObject, AssignedNodesOptions
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
        
        public bool flatten
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flatten"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flatten",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AssignedNodesOptionsCachedEntity() : base() { }

        public AssignedNodesOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}