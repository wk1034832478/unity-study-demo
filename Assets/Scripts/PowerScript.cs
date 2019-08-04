using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerScript : MonoBehaviour
{
    public GameObject ps;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 创建爆炸预制件，让炮弹消失，爆炸预制件在0.5s以后消失
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 p = this.transform.position;
        Quaternion q = Quaternion.identity;
        Instantiate(ps, p, q);
        Destroy(this.gameObject);
        
    }
}
