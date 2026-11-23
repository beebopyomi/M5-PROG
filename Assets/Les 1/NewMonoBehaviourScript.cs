using UnityEngine;
using UnityEngine.Tilemaps;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Tilemap mytilemap;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition ;
            Debug.Log(mousePos);     
            Vector3 woldpos = Camera.main.ScreenToWorldPoint(mousePos);
            woldpos.z = 0;
            Debug.Log(woldpos);
            Vector3 cellpos = mytilemap.WorldToCell(woldpos);
            Debug.Log(cellpos);
        }
        
    }
}
