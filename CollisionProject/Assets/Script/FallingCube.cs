using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCube : MonoBehaviour
{
    [SerializeField] float timeToFall;
    private MeshRenderer meshRenderer;
    private Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Rigidbody.useGravity = false;

        meshRenderer = Rigidbody.GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToFall)
        {
            Rigidbody.useGravity = true;
            meshRenderer.enabled = true;
        }


    }
    



}
