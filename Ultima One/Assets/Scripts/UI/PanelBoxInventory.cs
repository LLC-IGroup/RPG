using UnityEngine;
using UnityEngine.UI;

public class PanelBoxInventory : BasePanel {
    #region Fields
    // Text
    [SerializeField] public Text textCurrentVolume;
    [SerializeField] public Text textMaxVolume;
    [SerializeField] public Text textCurrentMass;
    [SerializeField] public Text textMaxMass;
    // Public 
    [SerializeField] public GameObject boxContent;
    [SerializeField] public GameObject itemCellPrefab;
    [SerializeField] public BaseSceneObject sceneObject;
    // Content

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
        panelName = "PanelBoxInventory";
        SetDrag(true);
    }
    override public void Start() {
        base.Start();
        UpdatePanel();

    }
    #endregion
    #region Function
    public void UpdatePanel(BaseSceneObject sceneObject) {
        base.UpdatePanel();
        this.sceneObject = sceneObject;
        // Clear Content
        RemoveAllChildren(boxContent);
        ItemInventory itemInventory = null;
        // Set Text
        textCurrentMass.text = sceneObject.GetItemInventory().GetCurrentMass().ToString();
        textCurrentVolume.text = sceneObject.GetItemInventory().GetCurrentVolume().ToString();
        textMaxMass.text = sceneObject.GetItemInventory().maxMass.ToString();
        textMaxVolume.text = sceneObject.GetItemInventory().maxVolume.ToString();
        // Create Inventory Cell
        if (sceneObject is BarrelObject) {
            BarrelObject barrelObject = sceneObject as BarrelObject;
            itemInventory = barrelObject.itemInventory; 
        }
        if (itemInventory != null)
            foreach (ItemCell itemCell in itemInventory.listItemCells) {
                GameObject panelItemCell = Instantiate(itemCellPrefab, boxContent.transform);
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