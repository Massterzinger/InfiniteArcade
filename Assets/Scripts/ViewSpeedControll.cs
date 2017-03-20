using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewSpeedControll : MonoBehaviour {
    public float TotalSpeed = 1;
    public float MaxSpeed = 1.06f;
    public float UpdationStepDelay = 5;
    public float UpdationStepValue = 0.0001f;
    public GameObject ItemsGenerator;
    Parallaxer[] px;
    ItemGenerator gen;
	// Use this for initialization
	void Start () {
        px = GetComponentsInChildren<Parallaxer>();
        gen = ItemsGenerator.GetComponent<ItemGenerator>();
        var c = StartCoroutine(SpeedUpdater());
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
            TotalSpeed += UpdationStepValue;
            gen.StartSpeed -= gen.SpeedIncreaser;
            if (TotalSpeed <= MaxSpeed)
            {
                UpdateParallax();
            }
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
