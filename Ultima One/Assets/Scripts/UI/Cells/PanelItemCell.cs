using UnityEngine;
using UnityEngine.UI;

public class PanelItemCell : BaseCellPanel {
    #region Fields
    [SerializeField] public Image imageInnerIcon;
    [SerializeField] public Image imageCount;
    [SerializeField] public Text textCount;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        base.OnValidate();

    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        base.Awake();
        // Set Params
        isDrag = true;
    }
    override public void Start() {
        base.Start();
        
    }
    #endregion
    #region Function
    // Public
    public void SetParam(ItemCell itemCell, BasePanel rootPanel) {
        base.SetParam(itemCell, rootPanel);
        imageInnerIcon.sprite = Resources.Load<Sprite>("Icons/"+itemCell.item.iconName);
        if (itemCell.count > 1) {
            imageCount.gameObject.SetActive(true);
            textCount.text = itemCell.count.ToString();
        } else imageCount.gameObject.SetActive(false);
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