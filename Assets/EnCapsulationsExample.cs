using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnCapsulationsExample : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private string _playerName;
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _experience;


    // Constructor (başlatıcı)
    public EnCapsulationsExample(string name, int initialHealth)
    {
        _playerName = name;
        _health = initialHealth;
        _experience = 0;
        _maxHealth = 100;
    }
    public string GetPlayerName()
    {
        return _playerName;
    }
    public void SetPlayerName(string name)
    {
        _playerName = name;
    }

    public int GetHealth()
    {
        return _health;
    }
    public void SetHealth(int value)
    {
        _health = value;
    }
    public void TakeDamage(int damage)
    {
        if (_health > 0 && _health <= _maxHealth)
        {
            SetHealth(_health - damage);
        }
        if (_health < 0)
            _health = 0;
        if (_health > _maxHealth)
            _health = _maxHealth;
    }
    public int GetExperience()
    {
        return _experience;
    }
    public void DisplayPlayerInfo()
    {
        Debug.Log($"Player Name: {_playerName}, Health: {_health}, Experience: {_experience}");
    }
    void Start()
    {
        // Yeni bir oyuncu yaratıyoruz
        EnCapsulationsExample player = new EnCapsulationsExample("Hero", 100);
        player.DisplayPlayerInfo();
        player.TakeDamage(20);
        player.AddExperience(50);
        player.DisplayPlayerInfo();
    }
    public void AddExperience(int value)
    {
        if(_experience>=0 && _experience<100)
            _experience += value;
        if (_experience < 0 && _experience > 100)
            _experience = 0;
    }
}
