using UnityEngine;
using UnityEngine.UI;

public class PanelDragCell : BaseCellPanel {
    #region Fields
    [SerializeField] public Image imageInnerIcon;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        base.OnValidate();

    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        base.Awake();

    }
    override public void Start() {
        base.Start();

    }
    override public void Update() {
        base.Update();

    }
    #endregion
    #region Function
    // Public
    public new void SetParam(BaseCell baseCell, BasePanel rootPanel) {
        base.SetParam(baseCell, rootPanel);
        if (baseCell is ItemCell) {
            ItemCell itemCell = baseCell as ItemCell;
            imageInnerIcon.sprite = Resources.Load<Sprite>("Icons/" + itemCell.item.iconName);
        }
        if (baseCell is EquipCell) {
            EquipCell equipCell = baseCell as EquipCell;
            // Check Empty Cell
            if (equipCell.item == null) {
                Destroy(gameObject);
                return;
            }
            imageInnerIcon.sprite = Resources.Load<Sprite>("Icons/" + equipCell.item.iconName);
        }
        if (baseCell is SkillCell) {
            SkillCell skillCell = baseCell as SkillCell;
            imageInnerIcon.sprite = Resources.Load<Sprite>("Icons/" + skillCell.skill.iconName);
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