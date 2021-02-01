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

    public interface WebGLRenderingContextOverloads : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<WebGLRenderingContextOverloadsCachedEntity>))]
    public class WebGLRenderingContextOverloadsCachedEntity : CachedEntityObject, WebGLRenderingContextOverloads
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

        #endregion
        
        #region Constructor
        public WebGLRenderingContextOverloadsCachedEntity() : base() { }

        public WebGLRenderingContextOverloadsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void bufferData(decimal target, decimal size, decimal usage)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bufferData" }, target, size, usage
                }
            );
        }

        public void bufferSubData(decimal target, decimal offset, ArrayBufferView data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bufferSubData" }, target, offset, data
                }
            );
        }

        public void compressedTexImage2D(decimal target, decimal level, decimal internalformat, decimal width, decimal height, decimal border, ArrayBufferView data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "compressedTexImage2D" }, target, level, internalformat, width, height, border, data
                }
            );
        }

        public void compressedTexSubImage2D(decimal target, decimal level, decimal xoffset, decimal yoffset, decimal width, decimal height, decimal format, ArrayBufferView data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "compressedTexSubImage2D" }, target, level, xoffset, yoffset, width, height, format, data
                }
            );
        }

        public void readPixels(decimal x, decimal y, decimal width, decimal height, decimal format, decimal type, ArrayBufferView pixels = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "readPixels" }, x, y, width, height, format, type, pixels
                }
            );
        }

        public void texImage2D(decimal target, decimal level, decimal internalformat, decimal width, decimal height, decimal border, decimal format, decimal type, ArrayBufferView pixels = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "texImage2D" }, target, level, internalformat, width, height, border, format, type, pixels
                }
            );
        }

        public void texSubImage2D(decimal target, decimal level, decimal xoffset, decimal yoffset, decimal width, decimal height, decimal format, decimal type, ArrayBufferView pixels = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "texSubImage2D" }, target, level, xoffset, yoffset, width, height, format, type, pixels
                }
            );
        }

        public void uniform1fv(decimal[] v, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform1fv" }, location, v
                }
            );
        }

        public void uniform1iv(Int32Array v, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform1iv" }, location, v
                }
            );
        }

        public void uniform2fv(decimal[] v, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform2fv" }, location, v
                }
            );
        }

        public void uniform2iv(Int32Array v, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform2iv" }, location, v
                }
            );
        }

        public void uniform3fv(decimal[] v, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform3fv" }, location, v
                }
            );
        }

        public void uniform3iv(Int32Array v, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform3iv" }, location, v
                }
            );
        }

        public void uniform4fv(decimal[] v, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform4fv" }, location, v
                }
            );
        }

        public void uniform4iv(Int32Array v, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform4iv" }, location, v
                }
            );
        }

        public void uniformMatrix2fv(bool transpose, decimal[] value, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniformMatrix2fv" }, location, transpose, value
                }
            );
        }

        public void uniformMatrix3fv(bool transpose, decimal[] value, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniformMatrix3fv" }, location, transpose, value
                }
            );
        }

        public void uniformMatrix4fv(bool transpose, decimal[] value, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniformMatrix4fv" }, location, transpose, value
                }
            );
        }
        #endregion
    }
}