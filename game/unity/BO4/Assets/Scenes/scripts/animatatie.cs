using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatatie : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private List<Sprite> spritesAnimatieLoopR;
    [SerializeField] private List<Sprite> spritesAnimatieLoopL;
    [SerializeField] private List<Sprite> spritesAnimatieLoopU;
    public List<Sprite> spritesAnimatieLoopD;
    [SerializeField] private Sprite sprite1;
    [SerializeField] private Sprite sprite2;
    [SerializeField] private Sprite sprite3;
    [SerializeField] private SpriteRenderer spritie;
    [SerializeField] private float interval;
    [SerializeField] private int welke;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //spritie.sprite = sprite1;
            animator.enabled = true;
            spritie.flipX = false;
            if (! animator.GetCurrentAnimatorStateInfo(0).IsName("Walk"))
            {
                animator.Play("Walk");
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            //spritie.sprite = sprite3;
            animator.enabled = true;
            spritie.flipX = true;
            if (! animator.GetCurrentAnimatorStateInfo(0).IsName("Walk"))
            {
                animator.Play("Walk");
            }
        }
        if(! Input.GetKey(KeyCode.D) && ! Input.GetKey(KeyCode.A))
        {
            animator.runtimeAnimatorController.animationClips.SetValue(0, 2);
            animator.enabled = false;
        }

    }
}
