using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public override void PlayBark()
    {
        playerAnim.Play("Base Layer.Bark", 0, 0);
        Debug.Log("Woof Woof");
    }
}
