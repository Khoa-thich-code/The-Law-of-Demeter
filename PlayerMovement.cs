using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed = 10f;
    [SerializeField] float jumpSpeed = 5f;
    private Vector2 moveInput;
    private Rigidbody2D Rigidbody;
    private Animator myAnimator;
    private CapsuleCollider2D myCapsuleCollider;
    void Start()
    {
        GetCompnentThings();
    }
    void Update()
    {
        run();
        FlipSprite();
    }

    private void GetCompnentThings()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myCapsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    void OnJump(InputValue value)
    {
        if (!myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            return;
        }
        if (value.isPressed) 
        {
            Rigidbody.velocity += new Vector2(0f, jumpSpeed);
        }

    }
    void run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * playerSpeed, Rigidbody.velocity.y);
        Rigidbody.velocity = playerVelocity;
        bool playerHasHorizontalSpeed = Mathf.Abs(Rigidbody.velocity.x) > Mathf.Epsilon;
        myAnimator.SetBool("isRunning", playerHasHorizontalSpeed);
    }
    void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(Rigidbody.velocity.x) > Mathf.Epsilon;
        if (playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(Rigidbody.velocity.x), 1f);
        }
    }
}
