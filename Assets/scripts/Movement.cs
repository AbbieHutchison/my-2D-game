    using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]         //Tell Unity to add theses components to the gameobject this code is attached to.
[RequireComponent(typeof(BoxCollider2D))]       //We will still need to tweak some of the settings.
public class Movement : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    public float moveSpeed = 5f;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        Debug.Log("Name of the object: "+ gameObject.name);
    }

    void Update()
    {
        float moveinputX = Input.GetAxisRaw("Horizontal"); // For horizontal movement (left/right)
        float moveinputY = Input.GetAxisRaw("Vertical");   // For vertical movement (up/down)

        animator.SetFloat("inputX", moveinputX);
        animator.SetFloat("inputY", moveinputY);

        // Normalise the vector so that we don't move faster when moving diagonally.
        Vector2 moveDirection = new Vector2(moveinputX, moveinputY);
        moveDirection.Normalize();

        // Assign velocity directly to the Rigidbody
        rb2d.velocity = moveDirection * moveSpeed;
    }
}