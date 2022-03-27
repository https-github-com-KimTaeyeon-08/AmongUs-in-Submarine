using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1_ctrl : MonoBehaviour
{
    public float speed = 3f;
    
    //public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animation>();

      
        // anim.CrossFade("Walk");

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
        transform.Translate(Vector3.back * Time.deltaTime);
    }
}
