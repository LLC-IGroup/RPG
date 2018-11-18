using UnityEngine;

public class BaseItem {
    #region Fields
    public string name;
    public string gameName;
    public ItemType itemType;
    public string description;
    public float quality;
    public float minQuality;
    public float durability;
    public float maxDurability;
    public string iconName;
    public string modelName;
    public bool stuck;
    public float maxStuck;
    public float volume;
    public float mass;
    public float minPrice;
    public bool use;
    #endregion
    #region Function
    // Constructor
    // Public
    public void SetBase(BaseItem baseItem) {
        name = baseItem.name;
        gameName = baseItem.gameName;
        itemType = baseItem.itemType;
        description = baseItem.description;
        quality = baseItem.quality;
        minQuality = baseItem.minQuality;
        durability = baseItem.durability;
        maxDurability = baseItem.maxDurability;
        iconName = baseItem.iconName;
        modelName = baseItem.modelName;
        stuck = baseItem.stuck;
        maxStuck = baseItem.maxStuck;
        volume = baseItem.volume;
        mass = baseItem.mass;
        minPrice = baseItem.minPrice;
        
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
    public enum ItemType {
        ERROR,

        RESOURCES,
        QUEST,

        WEAPON,
        TOW_HAND_WEAPON,

        TOOL,

        RING,
        AMULET,

        ARMOR,
        
        SHIELD,

        HELMET,
        BELT,
        GLOVES,
        PANTS,
        BOOTS,
        CLOAK,

        PET

    }
    #endregion
}       