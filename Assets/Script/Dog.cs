using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{// INHERITANCE
    public override void PlayBark()
    {
        // POLYMORPHISM
        playerAnim.Play("Base Layer.Bark", 0, 0);
        Debug.Log("Woof Woof");
    }
}
