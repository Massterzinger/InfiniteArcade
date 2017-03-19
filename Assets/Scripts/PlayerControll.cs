using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float Power;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.touchCount > 0 && Input.GetTouch(Input.touchCount - 1).phase == TouchPhase.Ended) //place this when compile to Device
        if(Input.GetMouseButtonDown(0))
        {
            Physics2D.gravity = -Physics2D.gravity;
            Power -= 1;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Goods")
        {
            Power += other.gameObject.GetComponent<ItemsMoving>().Bonus;
            Destroy(other.gameObject);
        }
    }
}
