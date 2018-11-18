using UnityEngine;

public class NPCParam {
    #region Fields
    public float agresion = 0;

    public PrivateParam privateParams = null;
    public Param param = null;
    public Abilitys abilitys = null;
    public Resistance resistance = null;
    public Regeneration regeneration = null;
    // Inventory
    public ItemInventory itemInventory = null;
    public SkillInventory skillInventory = null;
    public BuffInventory buffInventory = null;
    #endregion
    #region Function
    // Constructor
    public NPCParam() {
        privateParams = PrivateParam.Default();
        param = Param.Default();
        abilitys = Abilitys.Default();
        resistance = Resistance.Default();
        regeneration = Regeneration.Default();

        itemInventory = new ItemInventory(float.MaxValue, float.MaxValue);
        skillInventory = new SkillInventory();
        buffInventory = new BuffInventory();

    }
    // Public
    public void UpadateParam(BaseItem item) {
                                                                     
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