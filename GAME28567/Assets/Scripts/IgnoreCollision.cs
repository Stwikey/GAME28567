using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Collider2D collider2;

    public Vector2 start;
    public Vector2 end;


    void Start()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collider2);
        //checks collision, should return true
        //Debug.Log(Physics2D.GetIgnoreCollision(GetComponent<Collider2D>(), collider2));

    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collider2, false);
        //checks collision, should return false
        //Debug.Log(Physics2D.GetIgnoreCollision(GetComponent<Collider2D>(), collider2));

        Debug.Log(Physics2D.Linecast(start, end, 2).collider);
        Debug.DrawLine(start, end, Color.green);

    }

    private void OnTriggerEnter2D(Collider2D collision){
        //if colliding then print it to the console
        Debug.Log("Colliding");
    }
}
