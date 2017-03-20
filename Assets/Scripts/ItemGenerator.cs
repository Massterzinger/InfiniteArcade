using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
    public float Bounds = 3.45f;
    public float generationStepDelay;
    public float StartSpeed = -2.5f;
    public GameObject[] SomeItem;
    

	// Use this for initialization
	void Start () {
        var c = StartCoroutine(Generator());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator Generator()
    {
        WaitForSeconds delay = new WaitForSeconds(generationStepDelay);
        while (true)
        {
            yield return delay;
            GenerateItem();
        }
    }

    public void GenerateItem()
    {
        GameObject newItem = Instantiate(SomeItem[Random.Range(0, SomeItem.Length)], new Vector3(gameObject.transform.position.x, Random.Range(Bounds, -Bounds)), Quaternion.identity) as GameObject;
        newItem.GetComponent<ItemsMoving>().Speed = StartSpeed;
    }
}
