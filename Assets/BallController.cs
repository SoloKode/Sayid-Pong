using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    public Rigidbody2D rig;
    public void ResetBall(){
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 0);
        rigid.velocity = new Vector2(-rigid.velocity.x,0);
    }
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = speed;
    }
    public void ActivatePUSpeedUp(float magnitude){
        rigid.velocity *= magnitude;
    }
    // private void Update() {
    //     Debug.Log(rig.velocity);
    // }
}
