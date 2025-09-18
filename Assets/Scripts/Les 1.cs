using UnityEngine;

public class Scriptje : MonoBehaviour
{
    [SerializeField] Vector3 velocity = new Vector3(1, 1, 0);
    [SerializeField] Vector3 acceleration = new Vector3(0, -1, 0);
    Vector2 minscreen, maxscreen;

    void Start()
    {
        minscreen = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxscreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

   
    void Update()
    {
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        Vector3 temp = transform.position;

        if (temp.y > maxscreen.y)
        {
            velocity.y = -Mathf.Abs(velocity.y); 
        }

        if (temp.x > maxscreen.x)
        {
            velocity.x = -Mathf.Abs(velocity.x);
        }

        if (temp.y < minscreen.y)
        {
            velocity.y = Mathf.Abs(velocity.y);
        }

        if(temp.x < minscreen.x)
        {
            velocity.x = Mathf.Abs(velocity.x);
        }
    }
}
