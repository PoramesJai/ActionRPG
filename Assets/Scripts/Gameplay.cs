using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Character
{
    public string name; // Attributes
    public int hp;

    public Character(string n, int h) // Constructor
    {
        name = n;
        hp = h;
    }
}

public class Gameplay : MonoBehaviour
{
    TextMeshProUGUI playerName;
    Image hpBar;
    Character player;

    void Start()
    {
        player = new Character("PicoChan", 70);
        playerName = GameObject.Find("PlayerName").GetComponent<TextMeshProUGUI>();
        hpBar = GameObject.Find("HP").GetComponent<Image>();
        playerName.text = player.name;
    }

    void Update()
    {
        {
            hpBar.fillAmount = (float)player.hp / 100f;
        }
    }
}
