using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxer : MonoBehaviour
{
    public float Parallax;

    private MeshRenderer mr;
    private Material mat;
    private Vector2 offset;

    // Update is called once per frame
    void Update()
    {
        mr = gameObject.GetComponent<MeshRenderer>();
        mat = mr.material;
        offset = mat.mainTextureOffset;
        offset.x += Parallax * Time.deltaTime;
        mat.mainTextureOffset = offset;
    }
}