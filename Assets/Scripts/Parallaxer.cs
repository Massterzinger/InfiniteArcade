using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxer : MonoBehaviour {
    public Material FrontBlock;
    public Material BackMountain;
    public Material MidMountain;
    public Material FrontMountain;

    public float FrontBlockParallax, BackMountainParallax, MidMountainParallax, FrontMountainParallax;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        FrontBlock.mainTextureOffset = new Vector2( FrontBlock.mainTextureOffset.x+Time.deltaTime* FrontBlockParallax, FrontBlock.mainTextureOffset.y);
        BackMountain.mainTextureOffset = new Vector2(BackMountain.mainTextureOffset.x + Time.deltaTime * BackMountainParallax, BackMountain.mainTextureOffset.y);
        MidMountain.mainTextureOffset = new Vector2(MidMountain.mainTextureOffset.x + Time.deltaTime * MidMountainParallax, MidMountain.mainTextureOffset.y);
        FrontMountain.mainTextureOffset = new Vector2(FrontMountain.mainTextureOffset.x + Time.deltaTime * FrontMountainParallax, FrontMountain.mainTextureOffset.y);

    }
}
