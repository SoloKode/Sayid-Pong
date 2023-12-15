using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    int effectTime;
    int effectSpeedTime;
    float time;
    float time2;
    bool isEffect;
    bool isSpeed;
    float multi;
    public bool left;
    public bool right;
    public int speed;
    public int storedSpeed;
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        time = 0;
        time2 = 0;
        isEffect = false;
        effectTime  = 5;
        isSpeed = false;
        effectSpeedTime = 5;
        storedSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        // get input
        Vector3 movement = GetInput();
        print(gameObject.transform.localScale);
        // move object
        MoveObject(movement);
        if (isEffect == true || gameObject.transform.localScale.y != 2)
        {
            time += Time.deltaTime;
            if (time >= effectTime)
            {
                gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x, 2);
                isEffect = false;
                effectTime = 5;
                time = 0;
            }
        }
        if (isSpeed == true)
        {
            time2 += Time.deltaTime;
            if (time2 >= effectSpeedTime)
            {
                print(speed);
                speed = storedSpeed;
                isSpeed = false;
                effectSpeedTime = 5;
                print(speed);
                time2 = 0;
            }
        }
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
        Debug.Log("Test : " + movement);
        rigid.velocity = movement;
    }
    public void ActivatePUPaddle(float multiplierSize)
    {
        gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x, gameObject.transform.localScale.y + multiplierSize);
        // Akumulasi Effect Jika Bertumpuk
        if(isEffect == true){
            effectTime += 5;
        }
        isEffect = true;
        multi = multiplierSize;
    }
    public void ActivatePaddleSpeed(){
        speed += speed;
        if(isSpeed == true){
            effectSpeedTime += speed;
        }
        isSpeed = true;
    }
}
