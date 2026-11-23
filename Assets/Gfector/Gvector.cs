using UnityEngine;

public class Gvector : MonoBehaviour
{
    [SerializeField] private LineRenderer LR;
    [SerializeField] private Transform Head;  
    public Vector3 vector;     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LR.SetPosition(0, Vector3.zero);
        LR.SetPosition(1, new Vector3(vector.magnitude, 0, 0));
        Head.localPosition = new Vector3(vector.magnitude, 0, 0);
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(vector.y, vector.x)*Mathf.Rad2Deg);

    }
}
