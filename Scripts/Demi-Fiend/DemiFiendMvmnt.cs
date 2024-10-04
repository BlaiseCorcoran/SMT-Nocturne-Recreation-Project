using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemiFiendMvmnt : MonoBehaviour
{
    Rigidbody rb;
    public Animator animationPlay;
    public float MoveSpeed = 10;
    public Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        animationPlay.enabled = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float hInput = Input.GetAxis("Horizontal") * MoveSpeed;
        float vInput = Input.GetAxis("Vertical") * MoveSpeed;
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camRight.y = 0;

        Vector3 forwardRel = vInput*camForward;
        Vector3 rightRel = hInput*camRight;

        Vector3 mvmntDir = forwardRel+rightRel;

        rb.velocity = new Vector3(mvmntDir.x, rb.velocity.y, mvmntDir.z);

        transform.forward = new Vector3(rb.velocity.x, 0, rb.velocity.z);

        if (Input.anyKey)
        {
            animationPlay.enabled = true;
        }

        if (!Input.anyKey)
        {
            animationPlay.enabled = false;
            
        }
    }
}
