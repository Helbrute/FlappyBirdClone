using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    private MeshRenderer mesh;
    public float animationSpeed = 1f;

    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        mesh.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
