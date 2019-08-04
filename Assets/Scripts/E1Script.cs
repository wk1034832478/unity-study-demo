using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /**
     * 当被击中的时候，消灭自己
     */
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("ball")) {
            Destroy(this.gameObject);
        }
    }
}
