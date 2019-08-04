using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * 点击屏幕，发射球体
 */
public class TickScreenScript : MonoBehaviour
{
    public GameObject ball; // 预制件
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) { // 鼠标左键按下，Input.mousePosition为点击的位置
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; // 撞击物
            if (Physics.Raycast(ray, out hit)) { // 进行检测
                // 获取击中的位置
                Vector3 position =  hit.point;
                Debug.Log("撞击点：" + hit.point);
                Debug.Log("起始点：" + Camera.main.transform.position);
                Vector3 direction = 3 * (hit.point - Camera.main.transform.position); // 速度
                ball.transform.position = Camera.main.transform.position;
                GameObject newBall = Instantiate(ball);
                // 施加方向力
                Rigidbody rb = newBall.GetComponent<Rigidbody>();
                rb.AddForce(direction, ForceMode.VelocityChange);
            }
        }
    }
}
