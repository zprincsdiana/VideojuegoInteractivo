using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEfect : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float parallaxMultiplier;
    private Transform cameraTransform;
    private float spriteWidth,startPosition;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(3f*Time.deltaTime,0,0);
    }

}
