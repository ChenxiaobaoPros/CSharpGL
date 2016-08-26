﻿using CSharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewer
{
    /// <summary>
    /// base renderer for gridview.
    /// </summary>
    public abstract class GridViewRenderer : Renderer
    {
        /// <summary>
        /// gridview's model.
        /// </summary>
        public GridViewModel Grid { get; private set; }

        protected GridViewRenderer(vec3 originalWorldPosition, GridViewModel model, ShaderCode[] shaderCodes,
            PropertyNameMap propertyNameMap, params GLSwitch[] switches)
            : base(model, shaderCodes, propertyNameMap, switches)
        {
            this.WorldPosition = originalWorldPosition;
            this.Grid = model;
        }

    }
}
