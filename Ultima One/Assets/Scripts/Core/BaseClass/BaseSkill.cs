using UnityEngine;

public class BaseSkill {
    #region Fields
    public GameObject owner;
    public SkillType skillType;
    public string name;
    public string gameName;
    public string description;
    public string iconName;
    public string prefabName;
    public float castTime;
    public float coolDown;

    #endregion
    #region Function
    // Constructor
    // Public
    public void SetBase(BaseSkill baseSkill) {
        name = baseSkill.name;
        gameName = baseSkill.gameName;
        description = baseSkill.description;
        iconName = baseSkill.iconName;
        prefabName = baseSkill.prefabName;
        castTime = baseSkill.castTime;
        coolDown = baseSkill.coolDown;

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
    public enum SkillType {
        ERROR,
        ACTIVE,
        PASIVE,
        EMOTION
    }
    #endregion
}          