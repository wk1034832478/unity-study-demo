using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    public float moveSpeed;
    public float rotateAngle;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        if (v > 0)
        {
            this.gameObject.transform.Translate(new Vector3(moveSpeed, 0f, 0f), Space.Self);
        }
        else if (v < 0)
        {
            this.gameObject.transform.Translate(new Vector3(-moveSpeed, 0f, 0f), Space.Self);
        }
        if (h > 0)
        {
            rotateAngle += rotateSpeed * Time.deltaTime;
            this.gameObject.transform.eulerAngles = new Vector3(0, rotateAngle, 0);
        }
        else if (h < 0)
        {
            rotateAngle -= rotateSpeed * Time.deltaTime;
            this.gameObject.transform.eulerAngles = new Vector3(0, rotateAngle, 0);
        }
    }
}
