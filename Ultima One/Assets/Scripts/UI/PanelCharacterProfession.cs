using UnityEngine;
using UnityEngine.UI;

public class PanelCharacterProfession : BasePanel {
    #region Fields
    [SerializeField] public GameObject professionContent;
    // Private 
    [SerializeField] public GameObject profesiionCellPrefab;
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
        panelName = "PanelCharacterProfession";
        SetDrag(true);
    }
    override public void Start() {
        base.Start();
        UpdatePanel();

    }
    override public void UpdatePanel() {
        base.UpdatePanel();
        // Clear Content
        RemoveAllChildren(professionContent);
        // Create Proffesion PanelCell
        foreach (ProfessionCell professionCell in CharacterParam.professionInventory.GetAllProfessionCell()) {
            GameObject panelCell = Instantiate(profesiionCellPrefab, professionContent.transform);
            panelCell.GetComponent<PanelProfessionCell>().SetParam(professionCell);
        }
    }
    #endregion
    #region Function
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