using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent nma;
    public GameObject target;
    public GameObject ps;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Firing());
    }

    // 开炮
    IEnumerator Firing()
         {
            while (true) 
            {
                // 开火前进行重定位
                nma.SetDestination(target.transform.position);
                yield return new WaitForSeconds(0.5f); // 等待5秒再执行
                Debug.Log(string.Format("CurrentTime={0}", Time.time));
            }
        }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 p = this.transform.position;
        Quaternion q = Quaternion.identity;
        Instantiate(ps, p, q);
        Destroy(this.gameObject);

    }
}
