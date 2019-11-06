using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
struct PlayerInfo
{
    public string name;
    public int health;
    public int intellect;
    public int stamina;
    public int strength;
    public int power;
}

public class Player : MonoBehaviour
{
    public int numPlayers = 10;

    [SerializeField]
    PlayerInfo info;

    [SerializeField]
    PlayerInfo[] playersInfo;
    private string json;

    // Start is called before the first frame update
    private void Awake()
    {
        playersInfo = new PlayerInfo[numPlayers];
    }

    void Start()
    {
        json = Application.persistentDataPath + "/players.json";

        //playersInfo = new PlayerInfo[numPlayers];

        for (int i = 0; i < numPlayers; i++)
        {
            playersInfo[i] = new PlayerInfo();

            int randNum = Random.Range(1, 5);

            switch (randNum)
            {
                case 1:
                    playersInfo[i].name = "Joan";
                    break;
                case 2:
                    playersInfo[i].name = "Alex";
                    break;
                case 3:
                    playersInfo[i].name = "Alejandro";
                    break;
                case 4:
                    playersInfo[i].name = "Pau";
                    break;
                case 5:
                    playersInfo[i].name = "Andreu";
                    break;
            }

            playersInfo[i].health = Random.Range(20, 100);
            playersInfo[i].intellect = Random.Range(20, 100);
            playersInfo[i].stamina = Random.Range(20, 100);
            playersInfo[i].strength = Random.Range(20, 100);
            playersInfo[i].power = Random.Range(20, 100);

            Debug.Log("Name: " + playersInfo[i].name + " " + "Health: " + playersInfo[i].health + " " + "Intellect: " + playersInfo[i].intellect + " " + "Stamina: " + playersInfo[i].stamina + " " + "Strength: " + playersInfo[i].strength + " " + "Power: " + playersInfo[i].power + "\n");

        }
        DataPersistenceManager.SaveJsonArray(playersInfo, json, true);
        
        //GenerateCharacter(name, health, intellect, stamina, strength, power);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateCharacter (string name, int health, int intellect, int stamina, int strength, int power)
    {
        GenerateName(name);
        GenerateStats(health, intellect, stamina, strength, power);

    }

    public void GenerateStats (int health, int intellect, int stamina, int strength, int power)
    {


    }

    public void GenerateName(string name)
    {
        Debug.Log("Name: " + name + "\n");
    }
}
