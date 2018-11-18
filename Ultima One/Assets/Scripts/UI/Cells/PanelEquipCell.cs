using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelEquipCell : BaseCellPanel {
    #region Fields
    // Public
    [SerializeField] public Image imageTypeIcon;
    [SerializeField] public Image imageInnerIcon;
    [SerializeField] public BaseItem.ItemType equipType;
    [SerializeField] public int count;
    [SerializeField] public GameObject rootPanelObject;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        base.OnValidate();

    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        base.Awake();
        // Set Param
        isDrag = true;
        rootPanel = rootPanelObject.GetComponent<BasePanel>();
        baseCell = CharacterParam.equipInventory.GetCellByType(equipType, count);
    }
    override public void Start() {
        base.Start();



    }
    #endregion
    #region Function
    // Public
    public void SetParam(EquipCell equipCell, BasePanel rootPanel) {
        base.SetParam(equipCell, rootPanel);
        if (equipCell.item == null) {
            imageInnerIcon.gameObject.SetActive(false);
            imageTypeIcon.gameObject.SetActive(true);
        } else {
            imageInnerIcon.gameObject.SetActive(true);
            imageTypeIcon.gameObject.SetActive(false);
            EquipCell cell = CharacterParam.equipInventory.GetCellByType(equipType, count);
            imageInnerIcon.sprite = Resources.Load<Sprite>("Icons/"+ cell.item.iconName);
        }
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