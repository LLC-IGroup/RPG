using System;
using UnityEngine;

public class Param {
    #region Fields
    public string sceneName;
    public uint HP;
    public uint MP;
    public uint energy;
    public uint hunger;
    public uint lvl;
    public uint exp;
    public uint evasion; // Уклонение
    public uint concentration; // Концентрация 
    public uint critChance;
    public uint critPower;
    public uint difance;
    public float moveSpeed;
    
    #endregion
    #region Function
    // Constructor
    // Public
    static public Param Default() {
        Param param = new Param();
        param.sceneName = "NoName";
        param.lvl = 1;
        param.exp = 0;
        param.evasion = 0;
        param.concentration = 0;
        param.critChance = 0;
        param.critPower = 0;
        param.difance = 0;
        param.moveSpeed = 0;        
        return param;
    }
    public float GetMaxVolume() => CharacterParam.abilitys.agility * 5;
    public float GetMaxMass() => CharacterParam.abilitys.strength * 5;
    // Private
    #endregion
    #region Events

    #endregion
    #region Button Events

    #endregion
    #region Structs

    #endregion
    #region Enums

    #endregion
}