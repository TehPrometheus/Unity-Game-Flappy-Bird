using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrBird : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength = 10.0f;
    public scrLogic logic;
    private bool playerIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<scrLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerIsAlive)
            myRigidBody.velocity += Vector2.up * flapStrength;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerIsAlive = !playerIsAlive;
        logic.GameOver();
    }
}
