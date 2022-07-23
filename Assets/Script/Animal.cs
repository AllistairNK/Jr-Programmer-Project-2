using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    protected Animator playerAnim { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void PlayBark()
    {
        playerAnim.Play("Base Layer.Bark", 0, 0);
    }
    public void PlayEat()
    {
        playerAnim.Play("Base Layer.Eat", 0, 0);
    }

    public void PlaySit()
    {
        playerAnim.Play("Base Layer.SideDown", 0, 0);
    }
}
