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

    public interface CanvasUserInterface : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasUserInterfaceCachedEntity>))]
    public class CanvasUserInterfaceCachedEntity : CachedEntityObject, CanvasUserInterface
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
        public CanvasUserInterfaceCachedEntity() : base() { }

        public CanvasUserInterfaceCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void drawFocusIfNeeded(Element element)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawFocusIfNeeded" }, element
                }
            );
        }

        public void scrollPathIntoView()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scrollPathIntoView" }
                }
            );
        }
        #endregion
    }
}