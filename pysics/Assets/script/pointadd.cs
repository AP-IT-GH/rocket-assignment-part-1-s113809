using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointadd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerEnter(Collider collision)
    {
        scoremanager.instance.addpoint();
        Destroy(gameObject);
    }

}
