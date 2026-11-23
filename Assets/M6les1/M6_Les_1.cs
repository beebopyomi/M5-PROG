using UnityEngine;

public class M6_Les_1 : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private MeshRenderer MR;
    [SerializeField] private MeshFilter MF;

    Mesh mesh;
    Matrix3x3 matrix;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mesh = new Mesh();
        MF.mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        matrix = new Matrix3x3(points[0].position.x, points[1].position.x, points[2].position.x, points[0].position.y, points[1].position.y, points[2].position.y, 1, 1, 1);
        mesh.vertices = new Vector3[] { points[0].position, points[1].position, points[2].position };
        mesh.triangles = new int[] { 0, 1, 2 };
        mesh.RecalculateNormals();
        MF.mesh = mesh;

        if (matrix.Determinant() < 0)
        {
            MR.material.color = Color.red;


        }
        else
        {
            MR.material.color = Color.green;
        }
    }
}
