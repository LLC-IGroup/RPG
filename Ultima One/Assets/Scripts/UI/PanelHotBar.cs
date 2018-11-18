using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelHotBar : BasePanel {
    #region Fields
    [SerializeField] public GameObject[] panelCells;

    [SerializeField] public Button buttonCharacter;
    [SerializeField] public Button buttonCharacterProfession;
    [SerializeField] public Button buttonCharacterSkills;
    [SerializeField] public Button buttonCharacterInventory;
    [SerializeField] public Button buttonCharacterCraft;

    [SerializeField] public Button buttonChat;
    [SerializeField] public Button buttonMap;
    [SerializeField] public Button buttonCharacterQuest;
    [SerializeField] public Button buttonOptions;

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
        panelName = "PanelHotBar";
        SetDrag(false);
        // Set On Click
        buttonCharacter.onClick.AddListener(this.ButtonCharacter);
        buttonCharacterProfession.onClick.AddListener(this.ButtonCharacterProfession);
        buttonCharacterSkills.onClick.AddListener(this.ButtonCharacterSkills);
        buttonCharacterInventory.onClick.AddListener(this.ButtonCharacterInventory);
        buttonCharacterCraft.onClick.AddListener(this.ButtonCharacterCraft);
        buttonChat.onClick.AddListener(this.ButtonChat);
        buttonMap.onClick.AddListener(this.ButtonMap);
        buttonCharacterQuest.onClick.AddListener(this.ButtonCharacterQuest);
        buttonOptions.onClick.AddListener(this.ButtonOptions);

    }
    override public void Start() {
        base.Start();
        UpdatePanel();

    }
    override public void UpdatePanel() {
        base.UpdatePanel();
        foreach (HotBarCell hotBarCell in CharacterParam.hotBarInventory.listHotBarCell) {
            foreach (GameObject panelCellObject in panelCells) {
                if (hotBarCell.baseCell != null &&
                    panelCellObject.GetComponent<PanelHotBarCell>().cellCount == hotBarCell.count) {
                    panelCellObject.GetComponent<PanelHotBarCell>().SetParam(hotBarCell, this);
                }
            }
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
    private void ButtonCharacterSkills() {
        if (UIBuilder.IsOpen("PanelCharacterSkills"))
            UIBuilder.ClosePanel("PanelCharacterSkills");
        else UIBuilder.OpenPanel("PanelCharacterSkills");
    }
    private void ButtonCharacterProfession() {
        if (UIBuilder.IsOpen("PanelCharacterProfession"))
            UIBuilder.ClosePanel("PanelCharacterProfession");
        else UIBuilder.OpenPanel("PanelCharacterProfession");
    }
    private void ButtonOptions() {
        if (UIBuilder.IsOpen("PanelOptions"))
            UIBuilder.ClosePanel("PanelOptions");
        else UIBuilder.OpenPanel("PanelOptions");
    }
    private void ButtonCharacterQuest() {
        if (UIBuilder.IsOpen("PanelCharacterQuest"))
            UIBuilder.ClosePanel("PanelCharacterQuest");
        else UIBuilder.OpenPanel("PanelCharacterQuest");
    }
    private void ButtonMap() {
        if (UIBuilder.IsOpen("PanelMap"))
            UIBuilder.ClosePanel("PanelMap");
        else UIBuilder.OpenPanel("PanelMap");
    }
    private void ButtonChat() {
        if (UIBuilder.IsOpen("PanelChat"))
            UIBuilder.ClosePanel("PanelChat");
        else UIBuilder.OpenPanel("PanelChat");
    }
    private void ButtonCharacterCraft() {
        if (UIBuilder.IsOpen("PanelCharacterCraft"))
            UIBuilder.ClosePanel("PanelCharacterCraft");
        else UIBuilder.OpenPanel("PanelCharacterCraft");
    }
    private void ButtonCharacterInventory() {
        if (UIBuilder.IsOpen("PanelCharacterInventory"))
            UIBuilder.ClosePanel("PanelCharacterInventory");
        else
            UIBuilder.OpenPanel("PanelCharacterInventory");
    }
    private void ButtonCharacter() {
        if (UIBuilder.IsOpen("PanelCharacter"))
            UIBuilder.ClosePanel("PanelCharacter");
        else UIBuilder.OpenPanel("PanelCharacter");
    }
    #endregion
    #region Structs

    #endregion
    #region Enums

    #endregion
}      