using UnityEngine;
using UnityEngine.UI;

public class PanelSkillCell : BaseCellPanel {
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
        // Set Param
        isDrag = true;
    }
    override public void Start() {
        base.Start();
        
    }
    #endregion
    #region Function
    // Public
    public void SetParam(SkillCell skillCell, BasePanel rootPanel) {
        base.SetParam(skillCell, rootPanel);
        imageInnerIcon.sprite = Resources.Load<Sprite>("Icons/" + skillCell.skill.iconName);
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