﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
abstract public class cl_SectorObject
{
    //Variable Names
    public const string HULLPOINTS = "HullPoints";
    public const string HULLPOINTS_MAX = "HullPoints_Max";
    public const string SHIELD = "Shield";
    public const string SHIELD_MAX = "Shield_Max";

    //Tags
    public const string STATION = "Station";
    public const string SHIP = "Ship";
    public const string ASTEROID = "Asteroid";

    public const string TRADER = "Trader";
    public const string PIRATE = "Pirate";


    public List<string> tags;

    public Vector3 position;
    protected int hp, hpMax;
    protected int shield, shieldMax;

    public cl_SectorObject()
    {
        tags = new List<string>();
        position = Vector3.zero;
    }

    public cl_SectorObject(List<string> Tags, Vector3 Position)
    {

    }

    abstract public void Update();

    abstract public T GetVar<T>(string Name);

    abstract public void SetVar<T>(string Name, T Val);

    abstract public void CallMethod(string Name, params object[] args);
}