using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class masterPlayerController : MonoBehaviour
{
    protected Rigidbody2D player;

    [SerializeField]
    [Range(0.1f, 100f)]
    protected float moveForce = 5f;

    [SerializeField]
    [Range(0.1f, 25f)]
    protected float maxSpeed = 5f;

    [SerializeField]
    [Range(0.1f, 10f)]
    float brakeForce;

    float horizontalSpeed;
    float verticalSpeed;

    // Start is called before the first frame update
    void Awake()
    {
        player = GetComponent<Rigidbody2D>();

        horizontalSpeed = player.velocity.x;
        verticalSpeed = player.velocity.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void PerformMovement();

    protected void Move(int UpOrDown)
    { 
            player.AddForce(new Vector2(0, moveForce * UpOrDown + Time.fixedDeltaTime));
    }

    protected void ApplyBrake()
    {
        var velocity = player.velocity;
        velocity.y = Mathf.Lerp(velocity.y, 0.0f, brakeForce * Time.deltaTime);
        player.velocity = velocity;
    }
}
