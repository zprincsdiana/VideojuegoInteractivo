using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
  // Start is called before the first frame update
    public GameObject Nubes;
    public GameObject Spawn;

    void Start()
    {
        InvokeRepeating("a",1,25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void a(){
        Spawn = Instantiate (Nubes,transform.position,Quaternion.identity) as GameObject;
    }
}
