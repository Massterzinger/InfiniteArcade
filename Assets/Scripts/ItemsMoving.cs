using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsMoving : MonoBehaviour
{
    public float Speed;
    public float Bonus;
    public float KillZone = -10;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Speed * Time.deltaTime, 0, 0, Space.World);
        if(this.gameObject.transform.position.x < KillZone)
        {
            Destroy(gameObject);
        }
    }
}
