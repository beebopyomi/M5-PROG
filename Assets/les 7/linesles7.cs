using UnityEngine;

public class linesles7 : MonoBehaviour
{
    [SerializeField] Transform pointA;
    [SerializeField] Transform pointB;
    [SerializeField] Transform arrow;

    [SerializeField] LineRenderer lr;

    void Start()
    {

    }

    void Update()
    {
        if (lr != null && pointA != null && pointB != null)
        {
            lr.SetPosition(0, pointA.position);
            lr.SetPosition(1, pointB.position);
        }

        Vector3 direction = pointB.position - pointA.position;
        Vector3 midpoint = (pointA.position + pointB.position) * 0.5f;

        arrow.position = midpoint;
        arrow.up = direction.normalized;

    }
}