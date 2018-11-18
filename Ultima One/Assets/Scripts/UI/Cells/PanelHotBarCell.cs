using UnityEngine;
using UnityEngine.UI;

public class PanelHotBarCell : BaseCellPanel {
    #region Fields
    [SerializeField] public Image imageInnerIcon;
    [SerializeField] public uint cellCount;
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
        HotBarCell hotBarCell = CharacterParam.hotBarInventory.GetHotBarCell(cellCount);
        rootPanel = rootPanelObject.GetComponent<BasePanel>();
        base.SetParam(hotBarCell, rootPanel);

    }
    override public void Start() {
        base.Start();

    }
    #endregion
    #region Function
    // Public
    public void SetParam(HotBarCell hotBarCell, BasePanel rootPanel) {
        base.SetParam(baseCell, rootPanel);
        if (hotBarCell.baseCell == null) {
            imageInnerIcon.gameObject.SetActive(false);
            return;
        }
        if (hotBarCell.baseCell is ItemCell) {
            ItemCell itemCell = hotBarCell.baseCell as ItemCell;
            imageInnerIcon.sprite = Resources.Load<Sprite>("Icons/" + itemCell.item.iconName);
            imageInnerIcon.gameObject.SetActive(true);
        }
        if (hotBarCell.baseCell is SkillCell) {
            SkillCell skillCell = hotBarCell.baseCell as SkillCell;
            imageInnerIcon.sprite = Resources.Load<Sprite>("Icons/" + skillCell.skill.iconName);
            imageInnerIcon.gameObject.SetActive(true); 
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