using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle_script_en : MonoBehaviour
{
    [SerializeField] private ParticleSystem ps;

    
    bool thrust = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        thrust = Input.GetKey(KeyCode.Space);


        if (thrust)
        {
            ps.Play();
            


        }
        else { ps.Clear();
           
        }
        
    }
    
}
