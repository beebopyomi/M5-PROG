using UnityEngine;
using UnityEngine.Tilemaps;

public class penisballs : MonoBehaviour
{
    [SerializeField] Tilemap mytilemap;
    BoundsInt bounce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bounce = mytilemap.cellBounds;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MousePos = Input.mousePosition;
        
        Vector3 WorldPos = Camera.main.ScreenToWorldPoint(MousePos);
        WorldPos.z = 0;
        Vector3Int CellPos = mytilemap.WorldToCell(WorldPos);

        for(int i = 0+ bounce.position.x; i < bounce.size.x + bounce.x; i++)
        {
            for(int j = 0+bounce.position.y; j < bounce.size.y + bounce.y; j++)
            {
                Vector3Int pos = new Vector3Int(i, j, 0);
                mytilemap.SetTileFlags(pos, TileFlags.None);
                if(CellPos == pos)
                {
                    mytilemap.SetColor(pos, Color.red);
                }
                else
                {
                    mytilemap.SetColor(pos, Color.white);
                }
            }
        }
            //mytilemap.SetTileFlags(CellPos, TileFlags.None);
            //mytilemap.SetColor(CellPos, Color.red);
        
    }
}
