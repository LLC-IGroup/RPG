using UnityEngine;
using UnityEngine.UI;

public class PanelCharacterInventory : BasePanel {
    #region Fields
    [SerializeField] public Text textCurrentVolume;
    [SerializeField] public Text textMaxVolume;
    [SerializeField] public Text textCurrentMass;
    [SerializeField] public Text textMaxMass;
    // Content
    [SerializeField] public GameObject inventoryContent;
    [SerializeField] public GameObject itemCellPrefab; 
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
        panelName = "PanelCharacterInventory";
        SetDrag(true);
    }
    override public void Start() {
        base.Start();
        UpdatePanel();

    }
    #endregion
    #region Function
    override public void UpdatePanel() {
        base.UpdatePanel();
        // Clear Content
        RemoveAllChildren(inventoryContent);
        // Set Mass and Volume
        textCurrentVolume.text = CharacterParam.itemInventory.GetCurrentVolume().ToString();
        textCurrentMass.text = CharacterParam.itemInventory.GetCurrentMass().ToString();
        textMaxVolume.text = CharacterParam.param.GetMaxVolume().ToString();
        textMaxMass.text = CharacterParam.param.GetMaxMass().ToString();
        // Create Panel Item Cell
        foreach (ItemCell itemCell in CharacterParam.itemInventory.listItemCells) {
            GameObject panelItemCell = Instantiate(itemCellPrefab, inventoryContent.transform);
            panelItemCell.GetComponent<PanelItemCell>().SetParam(itemCell, this);
        }
    }
    override public void ClosePanel() {
        base.ClosePanel();

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
    #region Enums

    #endregion
}         