using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class GameData
{
   public int Point;
   public Vector3 playerPosition;
   public Directory<string, bool> AchievementUnlocked;

    public GameData()
    {
        this.Point = 0;
        playerPosition = Vector3.zero;
        AchievementUnlocked = new Directory<string, bool>();
    }
}
