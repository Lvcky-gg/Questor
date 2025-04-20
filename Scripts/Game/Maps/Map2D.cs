using Godot;
using System;

public partial class Map2D : TileMap
{
	public string GetTerrainDataForTile(int layer, bool data, int x, int y)
	{
		Vector2I position = new Vector2I(x, y);
		TileData tile = GetCellTileData(layer, position, data);

		if (tile != null)
		{
			return tile.GetCustomData("TerrainType").AsString();
		}

		return null;
	}

	private enum TerrainDataTypes
	{
		TerrainType
	}
}
