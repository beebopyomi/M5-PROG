using UnityEngine;

public class pLine : MonoBehaviour
{
    [SerializeField] LineRenderer lr;

    public Vector3 supportVector = new Vector3(0, 0, 0);
    public Vector3 directionVector= new Vector3(1, 2, 0);
    public float parameter;
    public Color LineColor = Color.white;
    void Start()
    {

    }

    void Update()
    {
        directionVector.Normalize();
        lr.SetPosition(0, supportVector - 20 * directionVector);
        lr.SetPosition(1, supportVector + 20 * directionVector);
    }

    public Vector3 intersectionPoint(pLine otherLine)
    {
        float determinant = directionVector.x * -otherLine.directionVector.y - -otherLine.directionVector.x * directionVector.y;

        if (determinant == 0)
        {
            Debug.Log("Lines are parallel");
            return Vector3.zero;
        }

        float a = otherLine.supportVector.x - supportVector.x;
        float b = otherLine.supportVector.y - supportVector.y;

        float c = -otherLine.directionVector.x;
        float d = -otherLine.directionVector.y;

        float leftDeterminant = a * d - b * c;
        float t1 = leftDeterminant / determinant;

        Vector3 intersectionPoint = supportVector + t1 * directionVector;

        return intersectionPoint;
    }

    public void SetColor(Color color)
    {
        LineColor = color;
        lr.startColor = LineColor;
        lr.endColor = LineColor;
    }
}