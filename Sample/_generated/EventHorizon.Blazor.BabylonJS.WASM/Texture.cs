/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Texture : BaseTexture
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static bool SerializeBuffers
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "Texture.SerializeBuffers"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "Texture.SerializeBuffers",
                    value
                );
            }
        }

        
        public static decimal NEAREST_SAMPLINGMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_SAMPLINGMODE"
                );
            }
        }

        
        public static decimal NEAREST_NEAREST_MIPLINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_NEAREST_MIPLINEAR"
                );
            }
        }

        
        public static decimal BILINEAR_SAMPLINGMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.BILINEAR_SAMPLINGMODE"
                );
            }
        }

        
        public static decimal LINEAR_LINEAR_MIPNEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.LINEAR_LINEAR_MIPNEAREST"
                );
            }
        }

        
        public static decimal TRILINEAR_SAMPLINGMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.TRILINEAR_SAMPLINGMODE"
                );
            }
        }

        
        public static decimal LINEAR_LINEAR_MIPLINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.LINEAR_LINEAR_MIPLINEAR"
                );
            }
        }

        
        public static decimal NEAREST_NEAREST_MIPNEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_NEAREST_MIPNEAREST"
                );
            }
        }

        
        public static decimal NEAREST_LINEAR_MIPNEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_LINEAR_MIPNEAREST"
                );
            }
        }

        
        public static decimal NEAREST_LINEAR_MIPLINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_LINEAR_MIPLINEAR"
                );
            }
        }

        
        public static decimal NEAREST_LINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_LINEAR"
                );
            }
        }

        
        public static decimal NEAREST_NEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_NEAREST"
                );
            }
        }

        
        public static decimal LINEAR_NEAREST_MIPNEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.LINEAR_NEAREST_MIPNEAREST"
                );
            }
        }

        
        public static decimal LINEAR_NEAREST_MIPLINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.LINEAR_NEAREST_MIPLINEAR"
                );
            }
        }

        
        public static decimal LINEAR_LINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.LINEAR_LINEAR"
                );
            }
        }

        
        public static decimal LINEAR_NEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.LINEAR_NEAREST"
                );
            }
        }

        
        public static decimal EXPLICIT_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.EXPLICIT_MODE"
                );
            }
        }

        
        public static decimal SPHERICAL_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.SPHERICAL_MODE"
                );
            }
        }

        
        public static decimal PLANAR_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.PLANAR_MODE"
                );
            }
        }

        
        public static decimal CUBIC_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.CUBIC_MODE"
                );
            }
        }

        
        public static decimal PROJECTION_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.PROJECTION_MODE"
                );
            }
        }

        
        public static decimal SKYBOX_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.SKYBOX_MODE"
                );
            }
        }

        
        public static decimal INVCUBIC_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.INVCUBIC_MODE"
                );
            }
        }

        
        public static decimal EQUIRECTANGULAR_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.EQUIRECTANGULAR_MODE"
                );
            }
        }

        
        public static decimal FIXED_EQUIRECTANGULAR_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.FIXED_EQUIRECTANGULAR_MODE"
                );
            }
        }

        
        public static decimal FIXED_EQUIRECTANGULAR_MIRRORED_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.FIXED_EQUIRECTANGULAR_MIRRORED_MODE"
                );
            }
        }

        
        public static decimal CLAMP_ADDRESSMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.CLAMP_ADDRESSMODE"
                );
            }
        }

        
        public static decimal WRAP_ADDRESSMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.WRAP_ADDRESSMODE"
                );
            }
        }

        
        public static decimal MIRROR_ADDRESSMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Texture.MIRROR_ADDRESSMODE"
                );
            }
        }

        
        public static bool UseSerializedUrlIfAny
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "Texture.UseSerializedUrlIfAny"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "Texture.UseSerializedUrlIfAny",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static BaseTexture Parse(object parsedTexture, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInteropt.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Texture", "Parse" }, parsedTexture, scene, rootUrl
                }
            );
        }

        public static Texture CreateFromBase64String(string data, string name, Scene scene, System.Nullable<bool> noMipmap = null, System.Nullable<bool> invertY = null, System.Nullable<decimal> samplingMode = null, CachedEntity onLoad = null, CachedEntity onError = null, System.Nullable<decimal> format = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Texture", "CreateFromBase64String" }, data, name, scene, noMipmap, invertY, samplingMode, onLoad, onError, format
                }
            );
        }

        public static Texture LoadFromDataString(string name, object buffer, Scene scene, System.Nullable<bool> deleteBuffer = null, System.Nullable<bool> noMipmap = null, System.Nullable<bool> invertY = null, System.Nullable<decimal> samplingMode = null, CachedEntity onLoad = null, CachedEntity onError = null, System.Nullable<decimal> format = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Texture", "LoadFromDataString" }, name, buffer, scene, deleteBuffer, noMipmap, invertY, samplingMode, onLoad, onError, format
                }
            );
        }
        #endregion

        #region Accessors
        
        public bool noMipmap
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "noMipmap"
                );
            }
        }

        
        public bool isBlocking
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isBlocking"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isBlocking",
                    value
                );
            }
        }

        
        public decimal samplingMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "samplingMode"
                );
            }
        }

        
        public bool invertY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "invertY"
                );
            }
        }
        #endregion

        #region Properties
        
        public string url
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "url"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "url",
                    value
                );
            }
        }

        
        public decimal uOffset
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "uOffset"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "uOffset",
                    value
                );
            }
        }

        
        public decimal vOffset
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "vOffset"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "vOffset",
                    value
                );
            }
        }

        
        public decimal uScale
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "uScale"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "uScale",
                    value
                );
            }
        }

        
        public decimal vScale
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "vScale"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "vScale",
                    value
                );
            }
        }

        
        public decimal uAng
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "uAng"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "uAng",
                    value
                );
            }
        }

        
        public decimal vAng
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "vAng"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "vAng",
                    value
                );
            }
        }

        
        public decimal wAng
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "wAng"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "wAng",
                    value
                );
            }
        }

        
        public decimal uRotationCenter
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "uRotationCenter"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "uRotationCenter",
                    value
                );
            }
        }

        
        public decimal vRotationCenter
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "vRotationCenter"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "vRotationCenter",
                    value
                );
            }
        }

        
        public decimal wRotationCenter
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "wRotationCenter"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "wRotationCenter",
                    value
                );
            }
        }

        
        public IInspectableCachedEntity[] inspectableCustomProperties
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<IInspectableCachedEntity>(
                    this.___guid,
                    "inspectableCustomProperties",
                    (entity) =>
                    {
                        return new IInspectableCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "inspectableCustomProperties",
                    value
                );
            }
        }

        private Observable<Texture> __onLoadObservable;
        public Observable<Texture> onLoadObservable
        {
            get
            {
            if(__onLoadObservable == null)
            {
                __onLoadObservable = EventHorizonBlazorInteropt.GetClass<Observable<Texture>>(
                    this.___guid,
                    "onLoadObservable",
                    (entity) =>
                    {
                        return new Observable<Texture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onLoadObservable;
            }
            set
            {
__onLoadObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onLoadObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Texture() : base() { }

        public Texture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Texture(
            Scene sceneOrEngine, string url = null, System.Nullable<bool> noMipmap = null, System.Nullable<bool> invertY = null, System.Nullable<decimal> samplingMode = null, CachedEntity onLoad = null, CachedEntity onError = null, string buffer = null, System.Nullable<bool> deleteBuffer = null, System.Nullable<decimal> format = null, string mimeType = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Texture" },
                url, sceneOrEngine, noMipmap, invertY, samplingMode, onLoad, onError, buffer, deleteBuffer, format, mimeType
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
// updateURL is not supported by the platform yet

        public void delayLoad()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "delayLoad" }
                }
            );
        }

        public Matrix getTextureMatrix(System.Nullable<decimal> uBase = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTextureMatrix" }, uBase
                }
            );
        }

        public Matrix getReflectionTextureMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getReflectionTextureMatrix" }
                }
            );
        }

        public Texture clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}