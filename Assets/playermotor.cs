using UnityEngine;

public class playermotor : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private playercontrolle motor;

        private void Start()
    {
        motor = GetComponent<playercontrolle>();
    }

    private void Update()
    {
        
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * xMov;
        Vector3 moveVertical = transform.forward * zMov;

        Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;

        motor.Move(velocity);
    }
}
