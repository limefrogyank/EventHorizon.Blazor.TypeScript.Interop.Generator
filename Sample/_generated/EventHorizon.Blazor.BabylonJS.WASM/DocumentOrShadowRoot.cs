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

    public interface DocumentOrShadowRoot : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<DocumentOrShadowRootCachedEntity>))]
    public class DocumentOrShadowRootCachedEntity : CachedEntityObject, DocumentOrShadowRoot
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
        private ElementCachedEntity __activeElement;
        public ElementCachedEntity activeElement
        {
            get
            {
            if(__activeElement == null)
            {
                __activeElement = EventHorizonBlazorInterop.GetClass<ElementCachedEntity>(
                    this.___guid,
                    "activeElement",
                    (entity) =>
                    {
                        return new ElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __activeElement;
            }
        }

        private ElementCachedEntity __fullscreenElement;
        public ElementCachedEntity fullscreenElement
        {
            get
            {
            if(__fullscreenElement == null)
            {
                __fullscreenElement = EventHorizonBlazorInterop.GetClass<ElementCachedEntity>(
                    this.___guid,
                    "fullscreenElement",
                    (entity) =>
                    {
                        return new ElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __fullscreenElement;
            }
        }

        private ElementCachedEntity __pointerLockElement;
        public ElementCachedEntity pointerLockElement
        {
            get
            {
            if(__pointerLockElement == null)
            {
                __pointerLockElement = EventHorizonBlazorInterop.GetClass<ElementCachedEntity>(
                    this.___guid,
                    "pointerLockElement",
                    (entity) =>
                    {
                        return new ElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointerLockElement;
            }
        }

        private StyleSheetListCachedEntity __styleSheets;
        public StyleSheetListCachedEntity styleSheets
        {
            get
            {
            if(__styleSheets == null)
            {
                __styleSheets = EventHorizonBlazorInterop.GetClass<StyleSheetListCachedEntity>(
                    this.___guid,
                    "styleSheets",
                    (entity) =>
                    {
                        return new StyleSheetListCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __styleSheets;
            }
        }
        #endregion
        
        #region Constructor
        public DocumentOrShadowRootCachedEntity() : base() { }

        public DocumentOrShadowRootCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public CaretPositionCachedEntity caretPositionFromPoint(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<CaretPositionCachedEntity>(
                entity => new CaretPositionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "caretPositionFromPoint" }, x, y
                }
            );
        }

        public RangeCachedEntity caretRangeFromPoint(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<RangeCachedEntity>(
                entity => new RangeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "caretRangeFromPoint" }, x, y
                }
            );
        }

        public ElementCachedEntity elementFromPoint(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<ElementCachedEntity>(
                entity => new ElementCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "elementFromPoint" }, x, y
                }
            );
        }

        public ElementCachedEntity[] elementsFromPoint(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<ElementCachedEntity>(
                entity => new ElementCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "elementsFromPoint" }, x, y
                }
            );
        }

        public SelectionCachedEntity getSelection()
        {
            return EventHorizonBlazorInterop.FuncClass<SelectionCachedEntity>(
                entity => new SelectionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSelection" }
                }
            );
        }
        #endregion
    }
}