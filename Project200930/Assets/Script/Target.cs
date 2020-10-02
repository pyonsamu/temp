using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject tipfront;
    public GameObject tipbottom;

    private float timer=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
    }

    private void OnTriggerStay(Collider other)
    {
        if(Time.time - timer > 0.1)
        {
            timer = Time.time;
            //Debug.Log("hit2");
            RaycastHit[] hit = new RaycastHit[100] ;
            int point = 0;
            foreach (RaycastHit h in Physics.RaycastAll(tipbottom.transform.position, tipfront.transform.position - tipbottom.transform.position))
            {
                if (h.collider)
                {
                    hit[point] = h;
                    point++;
                }
            }
            float dis = hit[0].distance - hit[1].distance;
            Debug.Log(dis);
        }
        
    }
    
}
