using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float MovementSpeed = 5;
    public float JumpForce = 2;

    private Rigidbody2D _rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetKey(KeyCode.Space) && Mathf.Abs(_rigidbody.velocity.y) < 0.01f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
