using UnityEngine;

public class Triangle : MonoBehaviour
{
    [SerializeField] Transform pointA;
    [SerializeField] Transform pointB;
    
    [SerializeField] Transform pointC;
    [SerializeField] Transform pointD;

    [SerializeField] LineRenderer lr;

    void Start()
    {
        
    }

    void Update()
    {
        lr.SetPosition(0, pointA.position);
        lr.SetPosition(1, pointB.position);
        lr.SetPosition(2, pointC.position);
        lr.SetPosition(3, pointA.position);
        lr.SetPosition(3, pointD.position);
    }
}
