using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public bool left;
    public bool right;
    public int speed;
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // get input
        Vector3 movement = GetInput();

        // move object
        MoveObject(movement);
    }
    private Vector2 GetInput()
    {
        if (Input.GetKey(KeyCode.W) && left == true)
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(KeyCode.S) && left == true)
        {
            return Vector2.down * speed;
        }

        if (Input.GetKey(KeyCode.UpArrow) && right == true)
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && right == true)
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }
    private void MoveObject(Vector2 movement)
    {
        rigid.velocity = movement;
    }
}
