using Godot;
using System;

[GlobalClass]
public partial class Map2D : TileMap
{

	public enum TerrainDataTypes
	{
		TerrainType
	}

	public string GetTerrainDataForTile(int layer, int dataIndex, int x, int y)
	{
		Vector2I position = new Vector2I(x, y);
		TileData tile = GetCellTileData(layer, position);

		if (tile != null)
		{
			string key = ((TerrainDataTypes)dataIndex).ToString();
			var customData = tile.GetCustomData(key);
			return customData.AsString();
		}

		return null;
	}
}
