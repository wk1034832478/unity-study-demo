using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }

}
