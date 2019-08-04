using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMove : MonoBehaviour
{
    public Animator animator;
    public float speed;
    public GameObject p;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirection = Input.GetAxis("Vertical");
        // 控制动画
        if (moveDirection != 0)
        {
            this.p.transform.Translate(new Vector3(0, 0f, speed), Space.World);
            animator.SetFloat("speed", 1f);
        }
        else {
            animator.SetFloat("speed", 0f);
        }
    }
}
