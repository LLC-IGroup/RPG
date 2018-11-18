using System;
using UnityEngine;

public class CharacterParam {
    #region Fields
    // Public
    static public PrivateParam privateParams = null;
    static public Param param = null;
    static public Abilitys abilitys = null;
    static public Resistance resistance = null;
    static public Regeneration regeneration = null;

    // Inventory
    static public EquipInventory equipInventory = null;
    static public ItemInventory itemInventory = null;
    static public SkillInventory skillInventory = null;
    static public BuffInventory buffInventory = null;
    static public ProfessionInventory professionInventory = null;
    static public RecipeInventory recipeInventory = null;
    static public HotBarInventory hotBarInventory = null;

    #endregion
    #region Function
    // Geters
    static public float GetMoveSpeed() {
        float result = param.moveSpeed;
        /// TODO::
        return result;
    }
    // Statick
    static public void UpadateParam(BaseItem item) {

        Debug.Log("Update Character Params");

    }
    public static void SetDefault() {
        privateParams = PrivateParam.Default();
        param = Param.Default();
        abilitys = Abilitys.Default();
        resistance = Resistance.Default();
        regeneration = Regeneration.Default();

        itemInventory = new ItemInventory(float.MaxValue, float.MaxValue);
        equipInventory = new EquipInventory();
        skillInventory = new SkillInventory();
        buffInventory = new BuffInventory();
        professionInventory = new ProfessionInventory();
        recipeInventory = new RecipeInventory();
        hotBarInventory = new HotBarInventory();

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

    #endregion
}           