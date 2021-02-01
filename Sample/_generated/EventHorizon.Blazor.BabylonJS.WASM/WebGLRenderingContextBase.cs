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

    public interface WebGLRenderingContextBase : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<WebGLRenderingContextBaseCachedEntity>))]
    public class WebGLRenderingContextBaseCachedEntity : CachedEntityObject, WebGLRenderingContextBase
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
        private HTMLCanvasElementCachedEntity __canvas;
        public HTMLCanvasElementCachedEntity canvas
        {
            get
            {
            if(__canvas == null)
            {
                __canvas = EventHorizonBlazorInterop.GetClass<HTMLCanvasElementCachedEntity>(
                    this.___guid,
                    "canvas",
                    (entity) =>
                    {
                        return new HTMLCanvasElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __canvas;
            }
        }

        
        public decimal drawingBufferHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "drawingBufferHeight"
                );
            }
        }

        
        public decimal drawingBufferWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "drawingBufferWidth"
                );
            }
        }

        
        public decimal ACTIVE_ATTRIBUTES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ACTIVE_ATTRIBUTES"
                );
            }
        }

        
        public decimal ACTIVE_TEXTURE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ACTIVE_TEXTURE"
                );
            }
        }

        
        public decimal ACTIVE_UNIFORMS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ACTIVE_UNIFORMS"
                );
            }
        }

        
        public decimal ALIASED_LINE_WIDTH_RANGE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ALIASED_LINE_WIDTH_RANGE"
                );
            }
        }

        
        public decimal ALIASED_POINT_SIZE_RANGE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ALIASED_POINT_SIZE_RANGE"
                );
            }
        }

        
        public decimal ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ALPHA"
                );
            }
        }

        
        public decimal ALPHA_BITS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ALPHA_BITS"
                );
            }
        }

        
        public decimal ALWAYS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ALWAYS"
                );
            }
        }

        
        public decimal ARRAY_BUFFER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ARRAY_BUFFER"
                );
            }
        }

        
        public decimal ARRAY_BUFFER_BINDING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ARRAY_BUFFER_BINDING"
                );
            }
        }

        
        public decimal ATTACHED_SHADERS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ATTACHED_SHADERS"
                );
            }
        }

        
        public decimal BACK
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BACK"
                );
            }
        }

        
        public decimal BLEND
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BLEND"
                );
            }
        }

        
        public decimal BLEND_COLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BLEND_COLOR"
                );
            }
        }

        
        public decimal BLEND_DST_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BLEND_DST_ALPHA"
                );
            }
        }

        
        public decimal BLEND_DST_RGB
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BLEND_DST_RGB"
                );
            }
        }

        
        public decimal BLEND_EQUATION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BLEND_EQUATION"
                );
            }
        }

        
        public decimal BLEND_EQUATION_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BLEND_EQUATION_ALPHA"
                );
            }
        }

        
        public decimal BLEND_EQUATION_RGB
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BLEND_EQUATION_RGB"
                );
            }
        }

        
        public decimal BLEND_SRC_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BLEND_SRC_ALPHA"
                );
            }
        }

        
        public decimal BLEND_SRC_RGB
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BLEND_SRC_RGB"
                );
            }
        }

        
        public decimal BLUE_BITS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BLUE_BITS"
                );
            }
        }

        
        public decimal BOOL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BOOL"
                );
            }
        }

        
        public decimal BOOL_VEC2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BOOL_VEC2"
                );
            }
        }

        
        public decimal BOOL_VEC3
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BOOL_VEC3"
                );
            }
        }

        
        public decimal BOOL_VEC4
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BOOL_VEC4"
                );
            }
        }

        
        public decimal BROWSER_DEFAULT_WEBGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BROWSER_DEFAULT_WEBGL"
                );
            }
        }

        
        public decimal BUFFER_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BUFFER_SIZE"
                );
            }
        }

        
        public decimal BUFFER_USAGE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BUFFER_USAGE"
                );
            }
        }

        
        public decimal BYTE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BYTE"
                );
            }
        }

        
        public decimal CCW
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CCW"
                );
            }
        }

        
        public decimal CLAMP_TO_EDGE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CLAMP_TO_EDGE"
                );
            }
        }

        
        public decimal COLOR_ATTACHMENT0
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COLOR_ATTACHMENT0"
                );
            }
        }

        
        public decimal COLOR_BUFFER_BIT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COLOR_BUFFER_BIT"
                );
            }
        }

        
        public decimal COLOR_CLEAR_VALUE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COLOR_CLEAR_VALUE"
                );
            }
        }

        
        public decimal COLOR_WRITEMASK
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COLOR_WRITEMASK"
                );
            }
        }

        
        public decimal COMPILE_STATUS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPILE_STATUS"
                );
            }
        }

        
        public decimal COMPRESSED_TEXTURE_FORMATS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_TEXTURE_FORMATS"
                );
            }
        }

        
        public decimal CONSTANT_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CONSTANT_ALPHA"
                );
            }
        }

        
        public decimal CONSTANT_COLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CONSTANT_COLOR"
                );
            }
        }

        
        public decimal CONTEXT_LOST_WEBGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CONTEXT_LOST_WEBGL"
                );
            }
        }

        
        public decimal CULL_FACE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CULL_FACE"
                );
            }
        }

        
        public decimal CULL_FACE_MODE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CULL_FACE_MODE"
                );
            }
        }

        
        public decimal CURRENT_PROGRAM
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CURRENT_PROGRAM"
                );
            }
        }

        
        public decimal CURRENT_VERTEX_ATTRIB
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CURRENT_VERTEX_ATTRIB"
                );
            }
        }

        
        public decimal CW
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CW"
                );
            }
        }

        
        public decimal DECR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DECR"
                );
            }
        }

        
        public decimal DECR_WRAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DECR_WRAP"
                );
            }
        }

        
        public decimal DELETE_STATUS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DELETE_STATUS"
                );
            }
        }

        
        public decimal DEPTH_ATTACHMENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH_ATTACHMENT"
                );
            }
        }

        
        public decimal DEPTH_BITS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH_BITS"
                );
            }
        }

        
        public decimal DEPTH_BUFFER_BIT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH_BUFFER_BIT"
                );
            }
        }

        
        public decimal DEPTH_CLEAR_VALUE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH_CLEAR_VALUE"
                );
            }
        }

        
        public decimal DEPTH_COMPONENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH_COMPONENT"
                );
            }
        }

        
        public decimal DEPTH_COMPONENT16
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH_COMPONENT16"
                );
            }
        }

        
        public decimal DEPTH_FUNC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH_FUNC"
                );
            }
        }

        
        public decimal DEPTH_RANGE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH_RANGE"
                );
            }
        }

        
        public decimal DEPTH_STENCIL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH_STENCIL"
                );
            }
        }

        
        public decimal DEPTH_STENCIL_ATTACHMENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH_STENCIL_ATTACHMENT"
                );
            }
        }

        
        public decimal DEPTH_TEST
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH_TEST"
                );
            }
        }

        
        public decimal DEPTH_WRITEMASK
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH_WRITEMASK"
                );
            }
        }

        
        public decimal DITHER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DITHER"
                );
            }
        }

        
        public decimal DONT_CARE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DONT_CARE"
                );
            }
        }

        
        public decimal DST_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DST_ALPHA"
                );
            }
        }

        
        public decimal DST_COLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DST_COLOR"
                );
            }
        }

        
        public decimal DYNAMIC_DRAW
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DYNAMIC_DRAW"
                );
            }
        }

        
        public decimal ELEMENT_ARRAY_BUFFER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ELEMENT_ARRAY_BUFFER"
                );
            }
        }

        
        public decimal ELEMENT_ARRAY_BUFFER_BINDING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ELEMENT_ARRAY_BUFFER_BINDING"
                );
            }
        }

        
        public decimal EQUAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "EQUAL"
                );
            }
        }

        
        public decimal FASTEST
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FASTEST"
                );
            }
        }

        
        public decimal FLOAT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FLOAT"
                );
            }
        }

        
        public decimal FLOAT_MAT2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FLOAT_MAT2"
                );
            }
        }

        
        public decimal FLOAT_MAT3
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FLOAT_MAT3"
                );
            }
        }

        
        public decimal FLOAT_MAT4
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FLOAT_MAT4"
                );
            }
        }

        
        public decimal FLOAT_VEC2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FLOAT_VEC2"
                );
            }
        }

        
        public decimal FLOAT_VEC3
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FLOAT_VEC3"
                );
            }
        }

        
        public decimal FLOAT_VEC4
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FLOAT_VEC4"
                );
            }
        }

        
        public decimal FRAGMENT_SHADER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRAGMENT_SHADER"
                );
            }
        }

        
        public decimal FRAMEBUFFER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRAMEBUFFER"
                );
            }
        }

        
        public decimal FRAMEBUFFER_ATTACHMENT_OBJECT_NAME
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRAMEBUFFER_ATTACHMENT_OBJECT_NAME"
                );
            }
        }

        
        public decimal FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE"
                );
            }
        }

        
        public decimal FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE"
                );
            }
        }

        
        public decimal FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL"
                );
            }
        }

        
        public decimal FRAMEBUFFER_BINDING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRAMEBUFFER_BINDING"
                );
            }
        }

        
        public decimal FRAMEBUFFER_COMPLETE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRAMEBUFFER_COMPLETE"
                );
            }
        }

        
        public decimal FRAMEBUFFER_INCOMPLETE_ATTACHMENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRAMEBUFFER_INCOMPLETE_ATTACHMENT"
                );
            }
        }

        
        public decimal FRAMEBUFFER_INCOMPLETE_DIMENSIONS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRAMEBUFFER_INCOMPLETE_DIMENSIONS"
                );
            }
        }

        
        public decimal FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT"
                );
            }
        }

        
        public decimal FRAMEBUFFER_UNSUPPORTED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRAMEBUFFER_UNSUPPORTED"
                );
            }
        }

        
        public decimal FRONT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRONT"
                );
            }
        }

        
        public decimal FRONT_AND_BACK
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRONT_AND_BACK"
                );
            }
        }

        
        public decimal FRONT_FACE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FRONT_FACE"
                );
            }
        }

        
        public decimal FUNC_ADD
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FUNC_ADD"
                );
            }
        }

        
        public decimal FUNC_REVERSE_SUBTRACT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FUNC_REVERSE_SUBTRACT"
                );
            }
        }

        
        public decimal FUNC_SUBTRACT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FUNC_SUBTRACT"
                );
            }
        }

        
        public decimal GENERATE_MIPMAP_HINT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "GENERATE_MIPMAP_HINT"
                );
            }
        }

        
        public decimal GEQUAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "GEQUAL"
                );
            }
        }

        
        public decimal GREATER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "GREATER"
                );
            }
        }

        
        public decimal GREEN_BITS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "GREEN_BITS"
                );
            }
        }

        
        public decimal HIGH_FLOAT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "HIGH_FLOAT"
                );
            }
        }

        
        public decimal HIGH_INT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "HIGH_INT"
                );
            }
        }

        
        public decimal IMPLEMENTATION_COLOR_READ_FORMAT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "IMPLEMENTATION_COLOR_READ_FORMAT"
                );
            }
        }

        
        public decimal IMPLEMENTATION_COLOR_READ_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "IMPLEMENTATION_COLOR_READ_TYPE"
                );
            }
        }

        
        public decimal INCR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INCR"
                );
            }
        }

        
        public decimal INCR_WRAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INCR_WRAP"
                );
            }
        }

        
        public decimal INT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INT"
                );
            }
        }

        
        public decimal INT_VEC2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INT_VEC2"
                );
            }
        }

        
        public decimal INT_VEC3
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INT_VEC3"
                );
            }
        }

        
        public decimal INT_VEC4
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INT_VEC4"
                );
            }
        }

        
        public decimal INVALID_ENUM
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INVALID_ENUM"
                );
            }
        }

        
        public decimal INVALID_FRAMEBUFFER_OPERATION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INVALID_FRAMEBUFFER_OPERATION"
                );
            }
        }

        
        public decimal INVALID_OPERATION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INVALID_OPERATION"
                );
            }
        }

        
        public decimal INVALID_VALUE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INVALID_VALUE"
                );
            }
        }

        
        public decimal INVERT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INVERT"
                );
            }
        }

        
        public decimal KEEP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "KEEP"
                );
            }
        }

        
        public decimal LEQUAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LEQUAL"
                );
            }
        }

        
        public decimal LESS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LESS"
                );
            }
        }

        
        public decimal LINEAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LINEAR"
                );
            }
        }

        
        public decimal LINEAR_MIPMAP_LINEAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LINEAR_MIPMAP_LINEAR"
                );
            }
        }

        
        public decimal LINEAR_MIPMAP_NEAREST
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LINEAR_MIPMAP_NEAREST"
                );
            }
        }

        
        public decimal LINES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LINES"
                );
            }
        }

        
        public decimal LINE_LOOP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LINE_LOOP"
                );
            }
        }

        
        public decimal LINE_STRIP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LINE_STRIP"
                );
            }
        }

        
        public decimal LINE_WIDTH
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LINE_WIDTH"
                );
            }
        }

        
        public decimal LINK_STATUS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LINK_STATUS"
                );
            }
        }

        
        public decimal LOW_FLOAT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LOW_FLOAT"
                );
            }
        }

        
        public decimal LOW_INT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LOW_INT"
                );
            }
        }

        
        public decimal LUMINANCE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LUMINANCE"
                );
            }
        }

        
        public decimal LUMINANCE_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LUMINANCE_ALPHA"
                );
            }
        }

        
        public decimal MAX_COMBINED_TEXTURE_IMAGE_UNITS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_COMBINED_TEXTURE_IMAGE_UNITS"
                );
            }
        }

        
        public decimal MAX_CUBE_MAP_TEXTURE_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_CUBE_MAP_TEXTURE_SIZE"
                );
            }
        }

        
        public decimal MAX_FRAGMENT_UNIFORM_VECTORS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_FRAGMENT_UNIFORM_VECTORS"
                );
            }
        }

        
        public decimal MAX_RENDERBUFFER_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_RENDERBUFFER_SIZE"
                );
            }
        }

        
        public decimal MAX_TEXTURE_IMAGE_UNITS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_TEXTURE_IMAGE_UNITS"
                );
            }
        }

        
        public decimal MAX_TEXTURE_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_TEXTURE_SIZE"
                );
            }
        }

        
        public decimal MAX_VARYING_VECTORS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_VARYING_VECTORS"
                );
            }
        }

        
        public decimal MAX_VERTEX_ATTRIBS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_VERTEX_ATTRIBS"
                );
            }
        }

        
        public decimal MAX_VERTEX_TEXTURE_IMAGE_UNITS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_VERTEX_TEXTURE_IMAGE_UNITS"
                );
            }
        }

        
        public decimal MAX_VERTEX_UNIFORM_VECTORS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_VERTEX_UNIFORM_VECTORS"
                );
            }
        }

        
        public decimal MAX_VIEWPORT_DIMS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_VIEWPORT_DIMS"
                );
            }
        }

        
        public decimal MEDIUM_FLOAT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MEDIUM_FLOAT"
                );
            }
        }

        
        public decimal MEDIUM_INT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MEDIUM_INT"
                );
            }
        }

        
        public decimal MIRRORED_REPEAT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MIRRORED_REPEAT"
                );
            }
        }

        
        public decimal NEAREST
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NEAREST"
                );
            }
        }

        
        public decimal NEAREST_MIPMAP_LINEAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NEAREST_MIPMAP_LINEAR"
                );
            }
        }

        
        public decimal NEAREST_MIPMAP_NEAREST
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NEAREST_MIPMAP_NEAREST"
                );
            }
        }

        
        public decimal NEVER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NEVER"
                );
            }
        }

        
        public decimal NICEST
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NICEST"
                );
            }
        }

        
        public decimal NONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NONE"
                );
            }
        }

        
        public decimal NOTEQUAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NOTEQUAL"
                );
            }
        }

        
        public decimal NO_ERROR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NO_ERROR"
                );
            }
        }

        
        public decimal ONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ONE"
                );
            }
        }

        
        public decimal ONE_MINUS_CONSTANT_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ONE_MINUS_CONSTANT_ALPHA"
                );
            }
        }

        
        public decimal ONE_MINUS_CONSTANT_COLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ONE_MINUS_CONSTANT_COLOR"
                );
            }
        }

        
        public decimal ONE_MINUS_DST_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ONE_MINUS_DST_ALPHA"
                );
            }
        }

        
        public decimal ONE_MINUS_DST_COLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ONE_MINUS_DST_COLOR"
                );
            }
        }

        
        public decimal ONE_MINUS_SRC_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ONE_MINUS_SRC_ALPHA"
                );
            }
        }

        
        public decimal ONE_MINUS_SRC_COLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ONE_MINUS_SRC_COLOR"
                );
            }
        }

        
        public decimal OUT_OF_MEMORY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "OUT_OF_MEMORY"
                );
            }
        }

        
        public decimal PACK_ALIGNMENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "PACK_ALIGNMENT"
                );
            }
        }

        
        public decimal POINTS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "POINTS"
                );
            }
        }

        
        public decimal POLYGON_OFFSET_FACTOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "POLYGON_OFFSET_FACTOR"
                );
            }
        }

        
        public decimal POLYGON_OFFSET_FILL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "POLYGON_OFFSET_FILL"
                );
            }
        }

        
        public decimal POLYGON_OFFSET_UNITS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "POLYGON_OFFSET_UNITS"
                );
            }
        }

        
        public decimal RED_BITS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RED_BITS"
                );
            }
        }

        
        public decimal RENDERBUFFER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RENDERBUFFER"
                );
            }
        }

        
        public decimal RENDERBUFFER_ALPHA_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RENDERBUFFER_ALPHA_SIZE"
                );
            }
        }

        
        public decimal RENDERBUFFER_BINDING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RENDERBUFFER_BINDING"
                );
            }
        }

        
        public decimal RENDERBUFFER_BLUE_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RENDERBUFFER_BLUE_SIZE"
                );
            }
        }

        
        public decimal RENDERBUFFER_DEPTH_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RENDERBUFFER_DEPTH_SIZE"
                );
            }
        }

        
        public decimal RENDERBUFFER_GREEN_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RENDERBUFFER_GREEN_SIZE"
                );
            }
        }

        
        public decimal RENDERBUFFER_HEIGHT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RENDERBUFFER_HEIGHT"
                );
            }
        }

        
        public decimal RENDERBUFFER_INTERNAL_FORMAT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RENDERBUFFER_INTERNAL_FORMAT"
                );
            }
        }

        
        public decimal RENDERBUFFER_RED_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RENDERBUFFER_RED_SIZE"
                );
            }
        }

        
        public decimal RENDERBUFFER_STENCIL_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RENDERBUFFER_STENCIL_SIZE"
                );
            }
        }

        
        public decimal RENDERBUFFER_WIDTH
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RENDERBUFFER_WIDTH"
                );
            }
        }

        
        public decimal RENDERER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RENDERER"
                );
            }
        }

        
        public decimal REPEAT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "REPEAT"
                );
            }
        }

        
        public decimal REPLACE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "REPLACE"
                );
            }
        }

        
        public decimal RGB
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RGB"
                );
            }
        }

        
        public decimal RGB565
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RGB565"
                );
            }
        }

        
        public decimal RGB5_A1
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RGB5_A1"
                );
            }
        }

        
        public decimal RGBA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RGBA"
                );
            }
        }

        
        public decimal RGBA4
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RGBA4"
                );
            }
        }

        
        public decimal SAMPLER_2D
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SAMPLER_2D"
                );
            }
        }

        
        public decimal SAMPLER_CUBE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SAMPLER_CUBE"
                );
            }
        }

        
        public decimal SAMPLES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SAMPLES"
                );
            }
        }

        
        public decimal SAMPLE_ALPHA_TO_COVERAGE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SAMPLE_ALPHA_TO_COVERAGE"
                );
            }
        }

        
        public decimal SAMPLE_BUFFERS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SAMPLE_BUFFERS"
                );
            }
        }

        
        public decimal SAMPLE_COVERAGE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SAMPLE_COVERAGE"
                );
            }
        }

        
        public decimal SAMPLE_COVERAGE_INVERT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SAMPLE_COVERAGE_INVERT"
                );
            }
        }

        
        public decimal SAMPLE_COVERAGE_VALUE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SAMPLE_COVERAGE_VALUE"
                );
            }
        }

        
        public decimal SCISSOR_BOX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SCISSOR_BOX"
                );
            }
        }

        
        public decimal SCISSOR_TEST
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SCISSOR_TEST"
                );
            }
        }

        
        public decimal SHADER_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SHADER_TYPE"
                );
            }
        }

        
        public decimal SHADING_LANGUAGE_VERSION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SHADING_LANGUAGE_VERSION"
                );
            }
        }

        
        public decimal SHORT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SHORT"
                );
            }
        }

        
        public decimal SRC_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SRC_ALPHA"
                );
            }
        }

        
        public decimal SRC_ALPHA_SATURATE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SRC_ALPHA_SATURATE"
                );
            }
        }

        
        public decimal SRC_COLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SRC_COLOR"
                );
            }
        }

        
        public decimal STATIC_DRAW
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STATIC_DRAW"
                );
            }
        }

        
        public decimal STENCIL_ATTACHMENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_ATTACHMENT"
                );
            }
        }

        
        public decimal STENCIL_BACK_FAIL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_BACK_FAIL"
                );
            }
        }

        
        public decimal STENCIL_BACK_FUNC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_BACK_FUNC"
                );
            }
        }

        
        public decimal STENCIL_BACK_PASS_DEPTH_FAIL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_BACK_PASS_DEPTH_FAIL"
                );
            }
        }

        
        public decimal STENCIL_BACK_PASS_DEPTH_PASS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_BACK_PASS_DEPTH_PASS"
                );
            }
        }

        
        public decimal STENCIL_BACK_REF
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_BACK_REF"
                );
            }
        }

        
        public decimal STENCIL_BACK_VALUE_MASK
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_BACK_VALUE_MASK"
                );
            }
        }

        
        public decimal STENCIL_BACK_WRITEMASK
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_BACK_WRITEMASK"
                );
            }
        }

        
        public decimal STENCIL_BITS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_BITS"
                );
            }
        }

        
        public decimal STENCIL_BUFFER_BIT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_BUFFER_BIT"
                );
            }
        }

        
        public decimal STENCIL_CLEAR_VALUE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_CLEAR_VALUE"
                );
            }
        }

        
        public decimal STENCIL_FAIL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_FAIL"
                );
            }
        }

        
        public decimal STENCIL_FUNC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_FUNC"
                );
            }
        }

        
        public decimal STENCIL_INDEX8
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_INDEX8"
                );
            }
        }

        
        public decimal STENCIL_PASS_DEPTH_FAIL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_PASS_DEPTH_FAIL"
                );
            }
        }

        
        public decimal STENCIL_PASS_DEPTH_PASS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_PASS_DEPTH_PASS"
                );
            }
        }

        
        public decimal STENCIL_REF
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_REF"
                );
            }
        }

        
        public decimal STENCIL_TEST
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_TEST"
                );
            }
        }

        
        public decimal STENCIL_VALUE_MASK
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_VALUE_MASK"
                );
            }
        }

        
        public decimal STENCIL_WRITEMASK
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STENCIL_WRITEMASK"
                );
            }
        }

        
        public decimal STREAM_DRAW
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "STREAM_DRAW"
                );
            }
        }

        
        public decimal SUBPIXEL_BITS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SUBPIXEL_BITS"
                );
            }
        }

        
        public decimal TEXTURE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE"
                );
            }
        }

        
        public decimal TEXTURE0
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE0"
                );
            }
        }

        
        public decimal TEXTURE1
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE1"
                );
            }
        }

        
        public decimal TEXTURE10
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE10"
                );
            }
        }

        
        public decimal TEXTURE11
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE11"
                );
            }
        }

        
        public decimal TEXTURE12
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE12"
                );
            }
        }

        
        public decimal TEXTURE13
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE13"
                );
            }
        }

        
        public decimal TEXTURE14
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE14"
                );
            }
        }

        
        public decimal TEXTURE15
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE15"
                );
            }
        }

        
        public decimal TEXTURE16
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE16"
                );
            }
        }

        
        public decimal TEXTURE17
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE17"
                );
            }
        }

        
        public decimal TEXTURE18
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE18"
                );
            }
        }

        
        public decimal TEXTURE19
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE19"
                );
            }
        }

        
        public decimal TEXTURE2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE2"
                );
            }
        }

        
        public decimal TEXTURE20
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE20"
                );
            }
        }

        
        public decimal TEXTURE21
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE21"
                );
            }
        }

        
        public decimal TEXTURE22
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE22"
                );
            }
        }

        
        public decimal TEXTURE23
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE23"
                );
            }
        }

        
        public decimal TEXTURE24
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE24"
                );
            }
        }

        
        public decimal TEXTURE25
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE25"
                );
            }
        }

        
        public decimal TEXTURE26
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE26"
                );
            }
        }

        
        public decimal TEXTURE27
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE27"
                );
            }
        }

        
        public decimal TEXTURE28
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE28"
                );
            }
        }

        
        public decimal TEXTURE29
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE29"
                );
            }
        }

        
        public decimal TEXTURE3
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE3"
                );
            }
        }

        
        public decimal TEXTURE30
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE30"
                );
            }
        }

        
        public decimal TEXTURE31
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE31"
                );
            }
        }

        
        public decimal TEXTURE4
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE4"
                );
            }
        }

        
        public decimal TEXTURE5
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE5"
                );
            }
        }

        
        public decimal TEXTURE6
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE6"
                );
            }
        }

        
        public decimal TEXTURE7
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE7"
                );
            }
        }

        
        public decimal TEXTURE8
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE8"
                );
            }
        }

        
        public decimal TEXTURE9
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE9"
                );
            }
        }

        
        public decimal TEXTURE_2D
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_2D"
                );
            }
        }

        
        public decimal TEXTURE_BINDING_2D
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_BINDING_2D"
                );
            }
        }

        
        public decimal TEXTURE_BINDING_CUBE_MAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_BINDING_CUBE_MAP"
                );
            }
        }

        
        public decimal TEXTURE_CUBE_MAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_CUBE_MAP"
                );
            }
        }

        
        public decimal TEXTURE_CUBE_MAP_NEGATIVE_X
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_CUBE_MAP_NEGATIVE_X"
                );
            }
        }

        
        public decimal TEXTURE_CUBE_MAP_NEGATIVE_Y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_CUBE_MAP_NEGATIVE_Y"
                );
            }
        }

        
        public decimal TEXTURE_CUBE_MAP_NEGATIVE_Z
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_CUBE_MAP_NEGATIVE_Z"
                );
            }
        }

        
        public decimal TEXTURE_CUBE_MAP_POSITIVE_X
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_CUBE_MAP_POSITIVE_X"
                );
            }
        }

        
        public decimal TEXTURE_CUBE_MAP_POSITIVE_Y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_CUBE_MAP_POSITIVE_Y"
                );
            }
        }

        
        public decimal TEXTURE_CUBE_MAP_POSITIVE_Z
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_CUBE_MAP_POSITIVE_Z"
                );
            }
        }

        
        public decimal TEXTURE_MAG_FILTER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_MAG_FILTER"
                );
            }
        }

        
        public decimal TEXTURE_MIN_FILTER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_MIN_FILTER"
                );
            }
        }

        
        public decimal TEXTURE_WRAP_S
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_WRAP_S"
                );
            }
        }

        
        public decimal TEXTURE_WRAP_T
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TEXTURE_WRAP_T"
                );
            }
        }

        
        public decimal TRIANGLES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TRIANGLES"
                );
            }
        }

        
        public decimal TRIANGLE_FAN
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TRIANGLE_FAN"
                );
            }
        }

        
        public decimal TRIANGLE_STRIP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TRIANGLE_STRIP"
                );
            }
        }

        
        public decimal UNPACK_ALIGNMENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNPACK_ALIGNMENT"
                );
            }
        }

        
        public decimal UNPACK_COLORSPACE_CONVERSION_WEBGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNPACK_COLORSPACE_CONVERSION_WEBGL"
                );
            }
        }

        
        public decimal UNPACK_FLIP_Y_WEBGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNPACK_FLIP_Y_WEBGL"
                );
            }
        }

        
        public decimal UNPACK_PREMULTIPLY_ALPHA_WEBGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNPACK_PREMULTIPLY_ALPHA_WEBGL"
                );
            }
        }

        
        public decimal UNSIGNED_BYTE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNSIGNED_BYTE"
                );
            }
        }

        
        public decimal UNSIGNED_INT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNSIGNED_INT"
                );
            }
        }

        
        public decimal UNSIGNED_SHORT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNSIGNED_SHORT"
                );
            }
        }

        
        public decimal UNSIGNED_SHORT_4_4_4_4
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNSIGNED_SHORT_4_4_4_4"
                );
            }
        }

        
        public decimal UNSIGNED_SHORT_5_5_5_1
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNSIGNED_SHORT_5_5_5_1"
                );
            }
        }

        
        public decimal UNSIGNED_SHORT_5_6_5
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNSIGNED_SHORT_5_6_5"
                );
            }
        }

        
        public decimal VALIDATE_STATUS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "VALIDATE_STATUS"
                );
            }
        }

        
        public decimal VENDOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "VENDOR"
                );
            }
        }

        
        public decimal VERSION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "VERSION"
                );
            }
        }

        
        public decimal VERTEX_ATTRIB_ARRAY_BUFFER_BINDING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "VERTEX_ATTRIB_ARRAY_BUFFER_BINDING"
                );
            }
        }

        
        public decimal VERTEX_ATTRIB_ARRAY_ENABLED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "VERTEX_ATTRIB_ARRAY_ENABLED"
                );
            }
        }

        
        public decimal VERTEX_ATTRIB_ARRAY_NORMALIZED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "VERTEX_ATTRIB_ARRAY_NORMALIZED"
                );
            }
        }

        
        public decimal VERTEX_ATTRIB_ARRAY_POINTER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "VERTEX_ATTRIB_ARRAY_POINTER"
                );
            }
        }

        
        public decimal VERTEX_ATTRIB_ARRAY_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "VERTEX_ATTRIB_ARRAY_SIZE"
                );
            }
        }

        
        public decimal VERTEX_ATTRIB_ARRAY_STRIDE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "VERTEX_ATTRIB_ARRAY_STRIDE"
                );
            }
        }

        
        public decimal VERTEX_ATTRIB_ARRAY_TYPE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "VERTEX_ATTRIB_ARRAY_TYPE"
                );
            }
        }

        
        public decimal VERTEX_SHADER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "VERTEX_SHADER"
                );
            }
        }

        
        public decimal VIEWPORT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "VIEWPORT"
                );
            }
        }

        
        public decimal ZERO
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ZERO"
                );
            }
        }
        #endregion
        
        #region Constructor
        public WebGLRenderingContextBaseCachedEntity() : base() { }

        public WebGLRenderingContextBaseCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void activeTexture(decimal texture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "activeTexture" }, texture
                }
            );
        }

        public void attachShader(WebGLProgram program, WebGLShader shader)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "attachShader" }, program, shader
                }
            );
        }

        public void bindAttribLocation(WebGLProgram program, decimal index, string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindAttribLocation" }, program, index, name
                }
            );
        }

        public void bindBuffer(decimal target, WebGLBuffer buffer = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindBuffer" }, target, buffer
                }
            );
        }

        public void bindFramebuffer(decimal target, WebGLFramebuffer framebuffer = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindFramebuffer" }, target, framebuffer
                }
            );
        }

        public void bindRenderbuffer(decimal target, WebGLRenderbuffer renderbuffer = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindRenderbuffer" }, target, renderbuffer
                }
            );
        }

        public void bindTexture(decimal target, WebGLTexture texture = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindTexture" }, target, texture
                }
            );
        }

        public void blendColor(decimal red, decimal green, decimal blue, decimal alpha)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "blendColor" }, red, green, blue, alpha
                }
            );
        }

        public void blendEquation(decimal mode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "blendEquation" }, mode
                }
            );
        }

        public void blendEquationSeparate(decimal modeRGB, decimal modeAlpha)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "blendEquationSeparate" }, modeRGB, modeAlpha
                }
            );
        }

        public void blendFunc(decimal sfactor, decimal dfactor)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "blendFunc" }, sfactor, dfactor
                }
            );
        }

        public void blendFuncSeparate(decimal srcRGB, decimal dstRGB, decimal srcAlpha, decimal dstAlpha)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "blendFuncSeparate" }, srcRGB, dstRGB, srcAlpha, dstAlpha
                }
            );
        }

        public decimal checkFramebufferStatus(decimal target)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "checkFramebufferStatus" }, target
                }
            );
        }

        public void clear(decimal mask)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }, mask
                }
            );
        }

        public void clearColor(decimal red, decimal green, decimal blue, decimal alpha)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearColor" }, red, green, blue, alpha
                }
            );
        }

        public void clearDepth(decimal depth)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearDepth" }, depth
                }
            );
        }

        public void clearStencil(decimal s)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearStencil" }, s
                }
            );
        }

        public void colorMask(bool red, bool green, bool blue, bool alpha)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "colorMask" }, red, green, blue, alpha
                }
            );
        }

        public void compileShader(WebGLShader shader)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "compileShader" }, shader
                }
            );
        }

        public void copyTexImage2D(decimal target, decimal level, decimal internalformat, decimal x, decimal y, decimal width, decimal height, decimal border)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyTexImage2D" }, target, level, internalformat, x, y, width, height, border
                }
            );
        }

        public void copyTexSubImage2D(decimal target, decimal level, decimal xoffset, decimal yoffset, decimal x, decimal y, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyTexSubImage2D" }, target, level, xoffset, yoffset, x, y, width, height
                }
            );
        }

        public WebGLBufferCachedEntity createBuffer()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLBufferCachedEntity>(
                entity => new WebGLBufferCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createBuffer" }
                }
            );
        }

        public WebGLFramebufferCachedEntity createFramebuffer()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLFramebufferCachedEntity>(
                entity => new WebGLFramebufferCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createFramebuffer" }
                }
            );
        }

        public WebGLProgramCachedEntity createProgram()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLProgramCachedEntity>(
                entity => new WebGLProgramCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createProgram" }
                }
            );
        }

        public WebGLRenderbufferCachedEntity createRenderbuffer()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderbufferCachedEntity>(
                entity => new WebGLRenderbufferCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createRenderbuffer" }
                }
            );
        }

        public WebGLShaderCachedEntity createShader(decimal type)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShaderCachedEntity>(
                entity => new WebGLShaderCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createShader" }, type
                }
            );
        }

        public WebGLTextureCachedEntity createTexture()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLTextureCachedEntity>(
                entity => new WebGLTextureCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createTexture" }
                }
            );
        }

        public void cullFace(decimal mode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "cullFace" }, mode
                }
            );
        }

        public void deleteBuffer(WebGLBuffer buffer = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteBuffer" }, buffer
                }
            );
        }

        public void deleteFramebuffer(WebGLFramebuffer framebuffer = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteFramebuffer" }, framebuffer
                }
            );
        }

        public void deleteProgram(WebGLProgram program = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteProgram" }, program
                }
            );
        }

        public void deleteRenderbuffer(WebGLRenderbuffer renderbuffer = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteRenderbuffer" }, renderbuffer
                }
            );
        }

        public void deleteShader(WebGLShader shader = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteShader" }, shader
                }
            );
        }

        public void deleteTexture(WebGLTexture texture = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteTexture" }, texture
                }
            );
        }

        public void depthFunc(decimal func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "depthFunc" }, func
                }
            );
        }

        public void depthMask(bool flag)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "depthMask" }, flag
                }
            );
        }

        public void depthRange(decimal zNear, decimal zFar)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "depthRange" }, zNear, zFar
                }
            );
        }

        public void detachShader(WebGLProgram program, WebGLShader shader)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "detachShader" }, program, shader
                }
            );
        }

        public void disable(decimal cap)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disable" }, cap
                }
            );
        }

        public void disableVertexAttribArray(decimal index)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableVertexAttribArray" }, index
                }
            );
        }

        public void drawArrays(decimal mode, decimal first, decimal count)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawArrays" }, mode, first, count
                }
            );
        }

        public void drawElements(decimal mode, decimal count, decimal type, decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawElements" }, mode, count, type, offset
                }
            );
        }

        public void enable(decimal cap)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enable" }, cap
                }
            );
        }

        public void enableVertexAttribArray(decimal index)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enableVertexAttribArray" }, index
                }
            );
        }

        public void finish()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "finish" }
                }
            );
        }

        public void flush()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "flush" }
                }
            );
        }

        public void framebufferRenderbuffer(decimal target, decimal attachment, decimal renderbuffertarget, WebGLRenderbuffer renderbuffer = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "framebufferRenderbuffer" }, target, attachment, renderbuffertarget, renderbuffer
                }
            );
        }

        public void framebufferTexture2D(decimal target, decimal attachment, decimal textarget, decimal level, WebGLTexture texture = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "framebufferTexture2D" }, target, attachment, textarget, texture, level
                }
            );
        }

        public void frontFace(decimal mode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "frontFace" }, mode
                }
            );
        }

        public void generateMipmap(decimal target)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "generateMipmap" }, target
                }
            );
        }

        public WebGLActiveInfoCachedEntity getActiveAttrib(WebGLProgram program, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLActiveInfoCachedEntity>(
                entity => new WebGLActiveInfoCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveAttrib" }, program, index
                }
            );
        }

        public WebGLActiveInfoCachedEntity getActiveUniform(WebGLProgram program, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLActiveInfoCachedEntity>(
                entity => new WebGLActiveInfoCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveUniform" }, program, index
                }
            );
        }

        public WebGLShaderCachedEntity[] getAttachedShaders(WebGLProgram program)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<WebGLShaderCachedEntity>(
                entity => new WebGLShaderCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAttachedShaders" }, program
                }
            );
        }

        public decimal getAttribLocation(WebGLProgram program, string name)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAttribLocation" }, program, name
                }
            );
        }

        public CachedEntity getBufferParameter(decimal target, decimal pname)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getBufferParameter" }, target, pname
                }
            );
        }

        public WebGLContextAttributesCachedEntity getContextAttributes()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLContextAttributesCachedEntity>(
                entity => new WebGLContextAttributesCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getContextAttributes" }
                }
            );
        }

        public decimal getError()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getError" }
                }
            );
        }

        public EXT_blend_minmaxCachedEntity getExtension(object extensionName)
        {
            return EventHorizonBlazorInterop.FuncClass<EXT_blend_minmaxCachedEntity>(
                entity => new EXT_blend_minmaxCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getExtension" }, extensionName
                }
            );
        }

        public CachedEntity getFramebufferAttachmentParameter(decimal target, decimal attachment, decimal pname)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getFramebufferAttachmentParameter" }, target, attachment, pname
                }
            );
        }

        public CachedEntity getParameter(decimal pname)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getParameter" }, pname
                }
            );
        }

        public string getProgramInfoLog(WebGLProgram program)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getProgramInfoLog" }, program
                }
            );
        }

        public CachedEntity getProgramParameter(WebGLProgram program, decimal pname)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getProgramParameter" }, program, pname
                }
            );
        }

        public CachedEntity getRenderbufferParameter(decimal target, decimal pname)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getRenderbufferParameter" }, target, pname
                }
            );
        }

        public string getShaderInfoLog(WebGLShader shader)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getShaderInfoLog" }, shader
                }
            );
        }

        public CachedEntity getShaderParameter(WebGLShader shader, decimal pname)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getShaderParameter" }, shader, pname
                }
            );
        }

        public WebGLShaderPrecisionFormatCachedEntity getShaderPrecisionFormat(decimal shadertype, decimal precisiontype)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLShaderPrecisionFormatCachedEntity>(
                entity => new WebGLShaderPrecisionFormatCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getShaderPrecisionFormat" }, shadertype, precisiontype
                }
            );
        }

        public string getShaderSource(WebGLShader shader)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getShaderSource" }, shader
                }
            );
        }

        public string[] getSupportedExtensions()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getSupportedExtensions" }
                }
            );
        }

        public CachedEntity getTexParameter(decimal target, decimal pname)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getTexParameter" }, target, pname
                }
            );
        }

        public CachedEntity getUniform(WebGLProgram program, WebGLUniformLocation location)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getUniform" }, program, location
                }
            );
        }

        public WebGLUniformLocationCachedEntity getUniformLocation(WebGLProgram program, string name)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLUniformLocationCachedEntity>(
                entity => new WebGLUniformLocationCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getUniformLocation" }, program, name
                }
            );
        }

        public CachedEntity getVertexAttrib(decimal index, decimal pname)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getVertexAttrib" }, index, pname
                }
            );
        }

        public decimal getVertexAttribOffset(decimal index, decimal pname)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVertexAttribOffset" }, index, pname
                }
            );
        }

        public void hint(decimal target, decimal mode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "hint" }, target, mode
                }
            );
        }

        public bool isBuffer(WebGLBuffer buffer = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isBuffer" }, buffer
                }
            );
        }

        public bool isContextLost()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isContextLost" }
                }
            );
        }

        public bool isEnabled(decimal cap)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isEnabled" }, cap
                }
            );
        }

        public bool isFramebuffer(WebGLFramebuffer framebuffer = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isFramebuffer" }, framebuffer
                }
            );
        }

        public bool isProgram(WebGLProgram program = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isProgram" }, program
                }
            );
        }

        public bool isRenderbuffer(WebGLRenderbuffer renderbuffer = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isRenderbuffer" }, renderbuffer
                }
            );
        }

        public bool isShader(WebGLShader shader = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isShader" }, shader
                }
            );
        }

        public bool isTexture(WebGLTexture texture = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isTexture" }, texture
                }
            );
        }

        public void lineWidth(decimal width)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "lineWidth" }, width
                }
            );
        }

        public void linkProgram(WebGLProgram program)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "linkProgram" }, program
                }
            );
        }

        public void pixelStorei(decimal pname, decimal param)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pixelStorei" }, pname, param
                }
            );
        }

        public void polygonOffset(decimal factor, decimal units)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "polygonOffset" }, factor, units
                }
            );
        }

        public void renderbufferStorage(decimal target, decimal internalformat, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "renderbufferStorage" }, target, internalformat, width, height
                }
            );
        }

        public void sampleCoverage(decimal value, bool invert)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sampleCoverage" }, value, invert
                }
            );
        }

        public void scissor(decimal x, decimal y, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scissor" }, x, y, width, height
                }
            );
        }

        public void shaderSource(WebGLShader shader, string source)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "shaderSource" }, shader, source
                }
            );
        }

        public void stencilFunc(decimal func, decimal @ref, decimal mask)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stencilFunc" }, func, @ref, mask
                }
            );
        }

        public void stencilFuncSeparate(decimal face, decimal func, decimal @ref, decimal mask)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stencilFuncSeparate" }, face, func, @ref, mask
                }
            );
        }

        public void stencilMask(decimal mask)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stencilMask" }, mask
                }
            );
        }

        public void stencilMaskSeparate(decimal face, decimal mask)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stencilMaskSeparate" }, face, mask
                }
            );
        }

        public void stencilOp(decimal fail, decimal zfail, decimal zpass)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stencilOp" }, fail, zfail, zpass
                }
            );
        }

        public void stencilOpSeparate(decimal face, decimal fail, decimal zfail, decimal zpass)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stencilOpSeparate" }, face, fail, zfail, zpass
                }
            );
        }

        public void texParameterf(decimal target, decimal pname, decimal param)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "texParameterf" }, target, pname, param
                }
            );
        }

        public void texParameteri(decimal target, decimal pname, decimal param)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "texParameteri" }, target, pname, param
                }
            );
        }

        public void uniform1f(decimal x, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform1f" }, location, x
                }
            );
        }

        public void uniform1i(decimal x, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform1i" }, location, x
                }
            );
        }

        public void uniform2f(decimal x, decimal y, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform2f" }, location, x, y
                }
            );
        }

        public void uniform2i(decimal x, decimal y, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform2i" }, location, x, y
                }
            );
        }

        public void uniform3f(decimal x, decimal y, decimal z, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform3f" }, location, x, y, z
                }
            );
        }

        public void uniform3i(decimal x, decimal y, decimal z, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform3i" }, location, x, y, z
                }
            );
        }

        public void uniform4f(decimal x, decimal y, decimal z, decimal w, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform4f" }, location, x, y, z, w
                }
            );
        }

        public void uniform4i(decimal x, decimal y, decimal z, decimal w, WebGLUniformLocation location = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uniform4i" }, location, x, y, z, w
                }
            );
        }

        public void useProgram(WebGLProgram program = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "useProgram" }, program
                }
            );
        }

        public void validateProgram(WebGLProgram program)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "validateProgram" }, program
                }
            );
        }

        public void vertexAttrib1f(decimal index, decimal x)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "vertexAttrib1f" }, index, x
                }
            );
        }

        public void vertexAttrib1fv(decimal index, decimal[] values)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "vertexAttrib1fv" }, index, values
                }
            );
        }

        public void vertexAttrib2f(decimal index, decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "vertexAttrib2f" }, index, x, y
                }
            );
        }

        public void vertexAttrib2fv(decimal index, decimal[] values)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "vertexAttrib2fv" }, index, values
                }
            );
        }

        public void vertexAttrib3f(decimal index, decimal x, decimal y, decimal z)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "vertexAttrib3f" }, index, x, y, z
                }
            );
        }

        public void vertexAttrib3fv(decimal index, decimal[] values)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "vertexAttrib3fv" }, index, values
                }
            );
        }

        public void vertexAttrib4f(decimal index, decimal x, decimal y, decimal z, decimal w)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "vertexAttrib4f" }, index, x, y, z, w
                }
            );
        }

        public void vertexAttrib4fv(decimal index, decimal[] values)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "vertexAttrib4fv" }, index, values
                }
            );
        }

        public void vertexAttribPointer(decimal index, decimal size, decimal type, bool normalized, decimal stride, decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "vertexAttribPointer" }, index, size, type, normalized, stride, offset
                }
            );
        }

        public void viewport(decimal x, decimal y, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "viewport" }, x, y, width, height
                }
            );
        }
        #endregion
    }
}