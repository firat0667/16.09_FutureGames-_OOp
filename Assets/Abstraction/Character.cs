using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected string characterName;
    protected int health;
    protected int experience;


    public abstract void Attack();

    public abstract void Defend();


    public void TakeDamage(int damage)
    {
        if(damage>0)
        {
            health-=damage;
            if (health < 0)
            {
                health = 0;
            }
            Debug.Log($"{characterName} has taken {damage} damage, health is now {health}.");
        }
    }
    public void AddExperience(int exp)
    {
        if (exp > 0)
        {
            experience += exp;
            Debug.Log($"{characterName} gained {exp} experience, total experience is now {experience}.");
        }
    }
    public void DisplayInfo()
    {
        Debug.Log($"Character: {characterName}, Health: {health}, Experience: {experience}");
    }
}
