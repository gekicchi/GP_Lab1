using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapVisualizer1 : MonoBehaviour
{
    [SerializeField]
    private Tilemap flootTilemap;
    [SerializeField]
    private TileBase floorTile;

    
    public void paintFloorTiles(IEnumerable<Vector2Int> floorPositions)
    {
        PaintTiles(floorPositions, flootTilemap, floorTile);
        
    }

    private void PaintTiles(IEnumerable<Vector2Int> positions, Tilemap tilemap, TileBase tile)
    {
        foreach (var position in positions)
        {
            PaintSingleTile(tilemap, position, tile);
        }
    }

    private void PaintSingleTile(Tilemap tilemap, Vector2Int position, TileBase tile)
    {
        var tilePosition = tilemap.WorldToCell((Vector3Int)position);
        tilemap.SetTile(tilePosition, tile);
    }


    public void Clear()
    {
        flootTilemap.ClearAllTiles();
    }
}
