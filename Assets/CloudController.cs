using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{

    public  float minimum = 1.0f;
    public  float magspeed = 10.0f;
    public  float  magnification = 0.07f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magspeed) *
            this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magspeed) * this.magnification);
    }
}
