using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowd : MonoBehaviour
{
    public int difficulty;
    private float speed = 1.5f;

    public Transform 
        start,
        end;

    bool
        goDance,
        goHome;


    // Start is called before the first frame update
    void Start()
    {
        goDance = false;
        goHome = true;
    }

    private void FixedUpdate()
    {
        if (goDance)
        {
            Dance();
        }
        else if (goHome)
        {
            Home();
        }
    }

    void Update()
    {
        if(Stats.popular / Stats.popMax * 100 > difficulty)
        {
            goDance = true;
            goHome = false;
        }
        else if (Stats.popular / Stats.popMax * 100 < difficulty)
        {
            goDance = false;
            goHome = true;
        }
    }

   

    void Dance()
    {
        transform.position = Vector2.MoveTowards(transform.position, end.position, speed * Time.deltaTime);
        if(transform.position.x < end.position.x && transform.localScale.x < 0)
        {
            Vector3 Scaler = transform.localScale;
            Scaler.x *= -1;   
            transform.localScale = Scaler;
        } 
        else if (transform.position.x > end.position.x && transform.localScale.x > 0)
        {
            Vector3 Scaler = transform.localScale;
            Scaler.x *= -1;
            transform.localScale = Scaler;
        }
    }

    void Home()
    {
        transform.position = Vector2.MoveTowards(transform.position, start.position, speed * Time.deltaTime);
        if (transform.position.x < start.position.x && transform.localScale.x < 0)
        {
            Vector3 Scaler = transform.localScale;
            Scaler.x *= -1;
            transform.localScale = Scaler;
        }
        else if (transform.position.x > start.position.x && transform.localScale.x > 0)
        {
            Vector3 Scaler = transform.localScale;
            Scaler.x *= -1;
            transform.localScale = Scaler;
        }
    }


}
