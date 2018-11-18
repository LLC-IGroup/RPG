using UnityEngine;

public class EquipCell : BaseCell {
    #region Fields
    public BaseItem item;
    public BaseItem.ItemType equipType;
    public int count;
    #endregion
    #region Function
    public EquipCell() {             
        item = null;
        equipType = BaseItem.ItemType.ERROR;
        count = 0;
    }
    // Public
    // Private
    #endregion
    #region Events

    #endregion
    #region Button Events

    #endregion
    #region Structs

    #endregion
}