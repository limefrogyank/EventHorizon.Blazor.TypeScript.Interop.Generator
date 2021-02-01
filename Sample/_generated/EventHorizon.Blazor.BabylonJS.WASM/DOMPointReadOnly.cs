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

    public interface DOMPointReadOnly : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<DOMPointReadOnlyCachedEntity>))]
    public class DOMPointReadOnlyCachedEntity : CachedEntityObject, DOMPointReadOnly
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
        
        public decimal w
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "w"
                );
            }
        }

        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
        }

        
        public decimal z
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "z"
                );
            }
        }
        #endregion
        
        #region Constructor
        public DOMPointReadOnlyCachedEntity() : base() { }

        public DOMPointReadOnlyCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public DOMPointCachedEntity matrixTransform(DOMMatrixInit matrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMPointCachedEntity>(
                entity => new DOMPointCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "matrixTransform" }, matrix
                }
            );
        }

        public CachedEntity toJSON()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }
        #endregion
    }
}