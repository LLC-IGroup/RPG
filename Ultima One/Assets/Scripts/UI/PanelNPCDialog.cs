using UnityEngine;
using UnityEngine.UI;

public class PanelNPCDialog : BasePanel {
    #region Fields
    [SerializeField] public Text textName;
    [SerializeField] public GameObject panelContent;
    [SerializeField] public GameObject panelMenu;
    [SerializeField] public GameObject panelDialogCellPrefab;
    [SerializeField] public GameObject panelDialogActionCellPrefab;

    [HideInInspector] public BaseNPC baseNPC;
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
        SetDrag(true);
        panelName = "PanelNPCDialog";

    }
    override public void Start() {
        base.Start();

    }
    public void Update() {

    }
    #endregion
    #region Function
    // Public
    public void SetParam(BaseNPC baseNPC) {
        this.baseNPC = baseNPC;
        textName.text = baseNPC.gameName;
        // Create Panel Content
        SetNode(baseNPC.dialogSystem.rootNode);
    }
    // Private
    private void SetNode(DialogNode dialogNode) {
        if (dialogNode == null)
            return;
        // Remove Old Nodes
        RemoveAllChildren(panelContent);
        RemoveAllChildren(panelMenu);
        // Set Node
        GameObject panelNPCDialogCell = Instantiate(panelDialogCellPrefab, panelContent.transform);
        panelNPCDialogCell.GetComponent<PanelNPCDialogCell>().SetParam(dialogNode);
        // Set Dialog Actions
        foreach (DialogAction dialogAction in dialogNode.listDialoAction) {
            GameObject dialogActionCell = Instantiate(panelDialogActionCellPrefab, panelMenu.transform);
            PanelDialogActionCell panelDialogActionCell = dialogActionCell.GetComponent<PanelDialogActionCell>();
            panelDialogActionCell.SetParam(dialogAction);
        }
    }
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