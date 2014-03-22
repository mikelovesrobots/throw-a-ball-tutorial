﻿/*!
 * X-UniTMX: A tiled map editor file importer for Unity3d
 * https://bitbucket.org/Chaoseiro/x-unitmx
 * 
 * Copyright 2013 Guilherme "Chaoseiro" Maia
 * Released under the MIT license
 * Check LICENSE.MIT for more details.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace X_UniTMX
{
	public enum SpriteEffects
	{
		None,
		FlipHorizontally,
		FlipVertically
	}

	/// <summary>
	/// A single tile in a TileLayer.
	/// </summary>
	public class Tile
	{
		/// <summary>
		/// Gets this tile's GID
		/// </summary>
		public int GID { get; private set; }

		/// <summary>
        /// Gets the Texture2D to use when drawing the tile.
        /// </summary>
        public TileSet TileSet { get; set; }

        /// <summary>
        /// Gets the source rectangle of the tile.
        /// </summary>
        public Rect Source { get; private set; }

        /// <summary>
        /// Gets the collection of properties for the tile.
        /// </summary>
        public PropertyCollection Properties { get; private set; }

        /// <summary>
        /// Gets or sets a color associated with the tile.
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets the SpriteEffects applied when drawing this tile.
        /// </summary>
        public SpriteEffects SpriteEffects { get; set; }

        /// <summary>
        /// Creates a new Tile object.
        /// </summary>
        /// <param name="texture">The texture that contains the tile image.</param>
        /// <param name="source">The source rectangle of the tile.</param>
		public Tile(TileSet tileSet, Rect source, int GID) : this(tileSet, source, GID, new PropertyCollection()) { }

        /// <summary>
        /// Creates a new Tile object.
        /// </summary>
        /// <param name="texture">The texture that contains the tile image.</param>
        /// <param name="source">The source rectangle of the tile.</param>
        /// <param name="properties">The initial property collection or null to create an empty property collection.</param>
        public Tile(TileSet tileSet, Rect source, int GID, PropertyCollection properties)
        {
            if (tileSet == null)
                throw new ArgumentNullException("tileSet");

			this.GID = GID;
            TileSet = tileSet;
            Source = source;
            Properties = properties ?? new PropertyCollection();
            Color = Color.white;
            //SpriteEffects = SpriteEffects.None;
        }

        /// <summary>
        /// Creates a copy of the current tile.
        /// </summary>
        /// <returns>A new Tile with the same properties as the current tile.</returns>
        public virtual Tile Clone()
        {
            return new Tile(TileSet, Source, GID, Properties);
        }
		/// TODO: Tile Renderer
        /// <summary>
        /// Draws the tile with an orthographic perspective.
        /// </summary>
        /// <param name="spriteBatch">The SpriteBatch to use when rendering the tile.</param>
        /// <param name="destBounds">The destination bounds where the tile should be drawn.</param>
        /// <param name="opacity">The level of opacity to use when drawing the tile.</param>
        /// <param name="layerDepth">The layer depth to use when drawing the tile.</param>
        /*public virtual void DrawOrthographic(SpriteBatch spriteBatch, Rectangle destBounds, float opacity, float layerDepth)
        {
            spriteBatch.Draw(TileSet, destBounds, Source, Color * opacity, 0f, Vector2.Zero, SpriteEffects, layerDepth);
        }
		*/
        /// <summary>
        /// Gets a string property
        /// </summary>
        /// <param name="property">Name of the property inside Tiled</param>
        /// <returns>The value of the property, String.Empty if property not found</returns>
        public string GetPropertyAsString(string property)
        {
            string str = string.Empty;
            Property p = null;
			if (Properties == null)
				return str;
            if (Properties.TryGetValue(property.ToLowerInvariant(), out p))
                str = p.RawValue;

            return str;
        }
        /// <summary>
        /// Gets a boolean property
        /// </summary>
        /// <param name="property">Name of the property inside Tiled</param>
        /// <returns>The value of the property</returns>
        public bool GetPropertyAsBoolean(string property)
        {
            bool b = false;
            string str = string.Empty;
            Property p = null;
			if (Properties == null)
				return b;
            if (Properties.TryGetValue(property.ToLowerInvariant(), out p))
                str = p.RawValue;

            Boolean.TryParse(str, out b);

            return b;
        }
        /// <summary>
        /// Gets an integer property
        /// </summary>
        /// <param name="property">Name of the property inside Tiled</param>
        /// <returns>The value of the property</returns>
        public int GetPropertyAsInt(string property)
        {
            int b = 0;
            string str = string.Empty;
            Property p = null;
			if (Properties == null)
				return b;
            if (Properties.TryGetValue(property.ToLowerInvariant(), out p))
                str = p.RawValue;

            Int32.TryParse(str, out b);

            return b;
        }
        /// <summary>
        /// Gets a float property
        /// </summary>
        /// <param name="property">Name of the property inside Tiled</param>
        /// <returns>The value of the property</returns>
        public float GetPropertyAsFloat(string property)
        {
            float b = 0;
            string str = string.Empty;
            Property p = null;
			if (Properties == null)
				return b;
            if (Properties.TryGetValue(property.ToLowerInvariant(), out p))
                str = p.RawValue;

            float.TryParse(str, out b);

            return b;
        }
	}
}
