﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Map_Settings", menuName = "Map/Map Settings", order = 0)]
public class MapSettings : ScriptableObject
{   
    public enum MapDifficulty {EASY = 1,MEDIUM = 2,HARD = 3};

    public MapDifficulty mapDifficulty;
    public StringVariable destinationScene;
    [Header("Rooms")]
    public int numberOfRooms = 3;
    public MapRoomSet startRoomSet;
    public MapRoomSet endRoomSet;
    [Header("Enemies")]
    public int totalEntitiesCost = 10;
    public MapEnemySet startEnemySet;
    public MapEnemySet endEnemySet;
}
