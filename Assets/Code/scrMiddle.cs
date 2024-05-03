using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMiddle : MonoBehaviour
{
    public scrLogic logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<scrLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
            logic.AddScore(1);
    }
}
