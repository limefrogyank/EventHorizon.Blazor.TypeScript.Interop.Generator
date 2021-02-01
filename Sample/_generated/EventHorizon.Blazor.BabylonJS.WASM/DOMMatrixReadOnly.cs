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

    public interface DOMMatrixReadOnly : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<DOMMatrixReadOnlyCachedEntity>))]
    public class DOMMatrixReadOnlyCachedEntity : CachedEntityObject, DOMMatrixReadOnly
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
        
        public decimal a
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "a"
                );
            }
        }

        
        public decimal b
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "b"
                );
            }
        }

        
        public decimal c
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "c"
                );
            }
        }

        
        public decimal d
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "d"
                );
            }
        }

        
        public decimal e
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "e"
                );
            }
        }

        
        public decimal f
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "f"
                );
            }
        }

        
        public bool is2D
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "is2D"
                );
            }
        }

        
        public bool isIdentity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isIdentity"
                );
            }
        }

        
        public decimal m11
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m11"
                );
            }
        }

        
        public decimal m12
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m12"
                );
            }
        }

        
        public decimal m13
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m13"
                );
            }
        }

        
        public decimal m14
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m14"
                );
            }
        }

        
        public decimal m21
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m21"
                );
            }
        }

        
        public decimal m22
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m22"
                );
            }
        }

        
        public decimal m23
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m23"
                );
            }
        }

        
        public decimal m24
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m24"
                );
            }
        }

        
        public decimal m31
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m31"
                );
            }
        }

        
        public decimal m32
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m32"
                );
            }
        }

        
        public decimal m33
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m33"
                );
            }
        }

        
        public decimal m34
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m34"
                );
            }
        }

        
        public decimal m41
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m41"
                );
            }
        }

        
        public decimal m42
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m42"
                );
            }
        }

        
        public decimal m43
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m43"
                );
            }
        }

        
        public decimal m44
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "m44"
                );
            }
        }
        #endregion
        
        #region Constructor
        public DOMMatrixReadOnlyCachedEntity() : base() { }

        public DOMMatrixReadOnlyCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public DOMMatrixCachedEntity flipX()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "flipX" }
                }
            );
        }

        public DOMMatrixCachedEntity flipY()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "flipY" }
                }
            );
        }

        public DOMMatrixCachedEntity inverse()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "inverse" }
                }
            );
        }

        public DOMMatrixCachedEntity multiply(DOMMatrixInit other = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, other
                }
            );
        }

        public DOMMatrixCachedEntity rotate(System.Nullable<decimal> rotX = null, System.Nullable<decimal> rotY = null, System.Nullable<decimal> rotZ = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, rotX, rotY, rotZ
                }
            );
        }

        public DOMMatrixCachedEntity rotateAxisAngle(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> angle = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateAxisAngle" }, x, y, z, angle
                }
            );
        }

        public DOMMatrixCachedEntity rotateFromVector(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateFromVector" }, x, y
                }
            );
        }

        public DOMMatrixCachedEntity scale(System.Nullable<decimal> scaleX = null, System.Nullable<decimal> scaleY = null, System.Nullable<decimal> scaleZ = null, System.Nullable<decimal> originX = null, System.Nullable<decimal> originY = null, System.Nullable<decimal> originZ = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, scaleX, scaleY, scaleZ, originX, originY, originZ
                }
            );
        }

        public DOMMatrixCachedEntity scale3d(System.Nullable<decimal> scale = null, System.Nullable<decimal> originX = null, System.Nullable<decimal> originY = null, System.Nullable<decimal> originZ = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale3d" }, scale, originX, originY, originZ
                }
            );
        }

        public DOMMatrixCachedEntity scaleNonUniform(System.Nullable<decimal> scaleX = null, System.Nullable<decimal> scaleY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleNonUniform" }, scaleX, scaleY
                }
            );
        }

        public DOMMatrixCachedEntity skewX(System.Nullable<decimal> sx = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "skewX" }, sx
                }
            );
        }

        public DOMMatrixCachedEntity skewY(System.Nullable<decimal> sy = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "skewY" }, sy
                }
            );
        }

        public decimal[] toFloat32Array()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "toFloat32Array" }
                }
            );
        }

        public Float64Array toFloat64Array()
        {
            return EventHorizonBlazorInterop.FuncClass<Float64Array>(
                entity => new Float64Array() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toFloat64Array" }
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

        public DOMPointCachedEntity transformPoint(DOMPointInit point = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMPointCachedEntity>(
                entity => new DOMPointCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transformPoint" }, point
                }
            );
        }

        public DOMMatrixCachedEntity translate(System.Nullable<decimal> tx = null, System.Nullable<decimal> ty = null, System.Nullable<decimal> tz = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, tx, ty, tz
                }
            );
        }

        public string toString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }
        #endregion
    }
}