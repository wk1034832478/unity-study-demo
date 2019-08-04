using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    public GameObject spaceship;
    public float powerSpeed;
    // 计算炮弹的相对距离
    public GameObject leftPowerModal;
    public GameObject rightPowerModal;
    public GameObject powerDirectSpeedModal;
    // 预制件
    public GameObject leftPower;
    public GameObject rightPower;
    public Vector3 leftDistance;
    public Vector3 rightDistance;

    public Vector3 speed;
    public float moveSpeed;
    public Animator animator;
    private float hAngle;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            leftDistance = leftPowerModal.transform.position - this.spaceship.transform.position; // 和左边炮火的距离
            rightDistance = rightPowerModal.transform.position - this.spaceship.transform.position; // 和左边炮火的距离
            // 计算当前炮弹所需速度
            speed = (powerDirectSpeedModal.transform.position - this.spaceship.transform.position) * powerSpeed;

            Vector3 lp = leftDistance + this.spaceship.transform.position;
            Vector3 rp = rightDistance + this.spaceship.transform.position;
            GameObject ln = Instantiate(leftPower, lp, Quaternion.identity);
            GameObject rn = Instantiate(rightPower, rp, Quaternion.identity);

            // 施加速度
            ln.GetComponent<Rigidbody>().AddForce(speed);
            rn.GetComponent<Rigidbody>().AddForce(speed);
        }

        float f = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        if (f != 0f)
        {
            this.transform.Translate(new Vector3(0, 0 ,-1 * f * moveSpeed), Space.Self);
            animator.SetBool("flying", true);
        }
        else {
            animator.SetBool("flying", false);
        }

        // 转向运动
        hAngle += (h * rotateSpeed);
        transform.rotation = Quaternion.Euler(0, hAngle, 0); 
    }
}
