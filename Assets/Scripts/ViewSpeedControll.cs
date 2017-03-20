using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewSpeedControll : MonoBehaviour {
    public float TotalSpeed = 1;
    public float MaxSpeed = 1.05f;
    public float UpdationStepDelay = 5;
    public float UpdationStepValue = 0.0001f;
    public GameObject ItemsGenerator;
    Parallaxer[] px;
    ItemGenerator gen;
    Coroutine c;
	// Use this for initialization
	void Start () {
        px = GetComponentsInChildren<Parallaxer>();
        gen = ItemsGenerator.GetComponent<ItemGenerator>();
        c = StartCoroutine(SpeedUpdater());
    }
	public void UpdateParallax()
    {
        for (int i = 0; i < px.Length; i++)
        {
            px[i].Parallax *= TotalSpeed;
        }
    }

    public IEnumerator SpeedUpdater()
    {
        WaitForSeconds delay = new WaitForSeconds(UpdationStepDelay);
        while (true)
        {
            yield return delay;            
            if (TotalSpeed <= MaxSpeed)
            {
                TotalSpeed += UpdationStepValue;
                gen.StartSpeed *= TotalSpeed;
                UpdateParallax();
            }
            else
            {
                StopCoroutine(c);
            }
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
