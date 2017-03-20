using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControll : MonoBehaviour
{
    public float Power;
    public Text PowerText;
    public GameObject MenuPanel;
    public Text EndText;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(Input.touchCount - 1).phase == TouchPhase.Ended) //place this when compile to Device
        //if(Input.GetMouseButtonDown(0))
        {
            if (Power > 0)
            {
                Physics2D.gravity = -Physics2D.gravity;
                Power -= 1;
                UpdatePower(Power);
            }
            else
            {
                Time.timeScale = 0;
                MenuPanel.SetActive(true);
                EndText.text += Time.time;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Goods")
        {
            Power += other.gameObject.GetComponent<ItemsMoving>().Bonus;
            UpdatePower(Power);
            Destroy(other.gameObject);

        }
    }

    void UpdatePower(float Pow)
    {
        PowerText.text = "Power: " + Pow;
    }

    public void GameOver()
    {

    }
}
