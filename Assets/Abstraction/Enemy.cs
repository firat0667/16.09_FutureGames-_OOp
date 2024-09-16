using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name)
    {
        characterName = name;
        health = 80;
        experience = 50;
    }
    public override void Attack()
    {
        Debug.Log($"{characterName} attacks with dark magic!");
    }

    public override void Defend()
    {
        Debug.Log($"{characterName} casts a protection spell!");
    }
}
