using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    float horizontal;
    float vertical;
    public Transform visuals;
    [SerializeField] GameManager gameManager;
     Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical"); 
    }
        
    private void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical);
        rb.linearVelocity = moveDirection * speed * Time.deltaTime;
        if (horizontal != 0)
        {
            if (horizontal < 0)
            {
                visuals.transform.localEulerAngles = new Vector3(0, 180, 0);
            }
            else if (horizontal > 0)
            {
                visuals.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
        }
    }
}
    

