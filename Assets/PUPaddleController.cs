using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public Rigidbody2D ballrigid;
    public PaddleController paddleRightController;
    public PaddleController paddleLeftController;
    public float multiplierSize;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (ballrigid.velocity.x > 0)
            {
                paddleLeftController.GetComponent<PaddleController>().ActivatePUPaddle(multiplierSize);
                print("Shot from Left");

            }
            else if (ballrigid.velocity.x < 0)
            {
                paddleRightController.GetComponent<PaddleController>().ActivatePUPaddle(multiplierSize);
                print("Shot from Right");
            }
            manager.RemovePowerUp(gameObject);
        }
    }
}
