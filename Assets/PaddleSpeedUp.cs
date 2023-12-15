using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSpeedUp: MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public Rigidbody2D ballrigid;
    public PaddleController paddleRightController;
    public PaddleController paddleLeftController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (ballrigid.velocity.x > 0)
            {
                paddleLeftController.GetComponent<PaddleController>().ActivatePaddleSpeed();
                print("Shot from Left");

            }
            else if (ballrigid.velocity.x < 0)
            {
                paddleRightController.GetComponent<PaddleController>().ActivatePaddleSpeed();
                print("Shot from Right");
            }
            manager.RemovePowerUp(gameObject);
        }
    }
}
