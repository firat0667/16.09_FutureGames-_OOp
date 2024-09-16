using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Player(string name)
    {
        characterName = name;
        health = 100;
        experience = 0;
    }

    public override void Attack()
    {
        Debug.Log($"{characterName} attacks with a sword!");
    }

    public override void Defend()
    {
        Debug.Log($"{characterName} blocks the attack with a shield!");
    }
}
