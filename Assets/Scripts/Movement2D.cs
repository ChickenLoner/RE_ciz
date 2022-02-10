using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    private float speed;
    public Vector3 movement;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");
        movement = new Vector3(movex, 0.0f ,movey);
        speed = run();
        animation();
        transform.position = transform.position + movement * Time.deltaTime * speed;
    }

    private float run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 4f;
            animator.SetBool("LeftShift", true);
        }
        else
        {
            speed = 2f;
            animator.SetBool("LeftShift", false);
        } 

        return speed;
    }

    private void animation()
    {
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.z);
        animator.SetFloat("Magnitude", movement.magnitude);
    }
}
