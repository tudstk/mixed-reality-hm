using UnityEngine;

public class DetectAndAttack : MonoBehaviour
{
    public GameObject cactus1;
    public GameObject cactus2;

    private Animator cactus1Animator;
    private Animator cactus2Animator;

    private bool isAttacking = false;

    private void Start()
    {
        cactus1Animator = cactus1.GetComponent<Animator>();
        cactus2Animator = cactus2.GetComponent<Animator>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(cactus1.transform.position, cactus2.transform.position);
        if (distance <= 0.25f)
        {
            if (!isAttacking)
            {
                isAttacking = true;
                cactus1Animator.SetBool("Attack", true);
                cactus2Animator.SetBool("Attack", true);
            }
        }
        else
        {
            isAttacking = false;
            cactus1Animator.SetBool("Attack", false);
            cactus2Animator.SetBool("Attack", false);
        }
    }
}
