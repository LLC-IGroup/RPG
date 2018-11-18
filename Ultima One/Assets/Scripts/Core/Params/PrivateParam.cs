using System;
using UnityEngine;

public class PrivateParam  {
    #region Fields
    // Public 
    public string name;
    public string avatarName;
    public CharacterSex sex;
    public uint professionPoints;
    public uint maxHP;
    public uint maxMP;
    public uint maxEnergy;
    public uint maxHunger;
    #endregion
    #region Function
    // Public
    static public PrivateParam Default() {
        PrivateParam privateParam = new PrivateParam();
        privateParam.name = "Character Name";
        privateParam.avatarName = "AvatarName";
        privateParam.sex = CharacterSex.NONE;
        privateParam.professionPoints = 500;

        return privateParam;
    }
    // Private
    #endregion
    #region Events

    #endregion
    #region Button Events

    #endregion
    #region Structs

    #endregion
    #region Enums
    public enum CharacterSex {
        NONE,

        MALE,
        FEMALE
    }
    #endregion
}       