using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetScript : MonoBehaviour
{
    public NavMeshAgent meshAgent;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit)) {
                Debug.Log("鼠标点击");
                meshAgent.SetDestination(hit.point);
            }
        }
    }
}
