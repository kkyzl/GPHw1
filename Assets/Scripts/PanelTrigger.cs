using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTrigger : MonoBehaviour
{
    public GameObject bridge;
    public int turnSpeed = 50;
    int trigger;
    // Start is called before the first frame update
    void Start()
    {
        trigger = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("enter panel");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //only exectue OnPlayerEnter if the player collides with this token.
        trigger += 1;
        if(trigger > 0)
        {
            bridge.GetComponent<Bridge>().putdown = true;
            bridge.GetComponent<Bridge>().turning = true;
        }
        Debug.Log("enter panel");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        trigger -= 1;
        if(trigger <= 0)
        {
            bridge.GetComponent<Bridge>().putdown = false;
            bridge.GetComponent<Bridge>().turning = true;
        }
        
        Debug.Log("leave panel");
    }
}
