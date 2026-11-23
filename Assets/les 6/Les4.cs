using UnityEngine;

public class Les4 : MonoBehaviour
{
    [SerializeField] Transform Ball;
    Vector3 velocity = new Vector3(2, 3, 0);
    public Matrix2x2 ReflectInAxisX;
    public Matrix2x2 ReflectInAxisY;

    public Vector2 minscreen,maxscreen;
    void Start()
    {
        ReflectInAxisX = new Matrix2x2(1, 0, 0, -1);
        ReflectInAxisY = new Matrix2x2(-1, 0, 0, 1);

        minscreen = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxscreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    void Update()
    {
        Ball.position += velocity * Time.deltaTime;

        if (Ball.position.y > maxscreen.y || Ball.position.y < minscreen.y)
        {
            velocity = ReflectInAxisX.Multiply(velocity);
        }

        if (Ball.position.x > maxscreen.x || Ball.position.x < minscreen.x)
        {
            velocity = ReflectInAxisY.Multiply(velocity);
        }
    }
}