using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
    public LogicScript logic;
    public bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        MyRigidBody.gravityScale = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive)
            MyRigidBody.velocity = Vector2.up * 10;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        alive =  false;
    }
}
