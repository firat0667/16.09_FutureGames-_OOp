using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractionGame : MonoBehaviour
{
    void Start()
    {
        // Player ve Enemy karakterleri yaratıyoruz
        Player player = new Player("Hero");
        Enemy enemy = new Enemy("Dark Lord");

        player.DisplayInfo();
        enemy.DisplayInfo();

        player.Attack();
        enemy.Defend();

        enemy.Attack();
        player.Defend();

        player.TakeDamage(20);
        enemy.TakeDamage(30);

        player.AddExperience(100);
        enemy.AddExperience(25);

        player.DisplayInfo();
        enemy.DisplayInfo();
    }
}
