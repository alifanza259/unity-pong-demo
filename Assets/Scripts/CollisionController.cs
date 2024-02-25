using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "Racket1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHeight;

        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "Racket1" || c.gameObject.name == "Racket2")
        {
            BounceFromRacket(c);
        }
        else if (c.gameObject.name == "WallLeft")
        {
            scoreController.GoalPlayer2();
            StartCoroutine(ballMovement.StartBall(true));
        }
        else if (c.gameObject.name == "WallRight")
        {
            scoreController.GoalPlayer1();
            StartCoroutine(ballMovement.StartBall(false));
        }
    }
}
