using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public float speed ;



    public void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); //taking input
        MoveCharacter(horizontal);
        playMovementAnimation(horizontal);
    }
    private void MoveCharacter(float horizontal)
    {
        Vector3 position = transform.position;
        position.x = position.x + horizontal * speed * Time.deltaTime;
        transform.position = position;
        
            }

    private void playMovementAnimation(float horizontal)
    {
        animator.SetFloat("speed", Mathf.Abs(horizontal));
        Vector3 scale = transform.localScale;
        if (horizontal < 0)
        {


            scale.x = -1 * Mathf.Abs(scale.x);

        }
        else if (horizontal > 0)
        {
            scale.x = Mathf.Abs(scale.x);

        }
        transform.localScale = scale;
        float vertical = Input.GetAxisRaw("jump");
        if (vertical > 0)
        {
            animator.SetBool("jump", true);

        }
        else
        {
            animator.SetBool("jump", false);
        }
    }
    /* public void isCrouch()
{
    bool isCrouch = Input.GetKey);
    animator.SetBool("isCrouch", isCrouch);


}*/

}
