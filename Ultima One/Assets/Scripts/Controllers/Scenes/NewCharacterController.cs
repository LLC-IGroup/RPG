using System;
using UnityEngine;

public class NewCharacterController : MonoBehaviour {
    #region Fields
    // Private
    [HideInInspector] private GameObject panelCreateControl;
    [HideInInspector] private uint currentStep = 1;
    [HideInInspector] private uint steps = 3;
    [SerializeField] public GameObject panelStep1;
    [SerializeField] public GameObject panelStep2;
    [SerializeField] public GameObject panelStep3;
    // Static
    [HideInInspector] static public CreateCharacterParams createParams;
    #endregion
    #region Unity Editor
    public void OnValidate() {

    }
    #endregion
    #region MonoBehaviour
    public void Awake() {
        // Set Param
        createParams = new CreateCharacterParams();
        OpenDefaultPanels();
        PanelHistoryCell.Select += this.SelectHistory;
    }
    public void Start() {
        panelCreateControl.GetComponent<PanelCreateControl>().buttonBack.onClick.AddListener(this.ButtonBack);
        panelCreateControl.GetComponent<PanelCreateControl>().buttonNext.onClick.AddListener(this.ButtonNext);
        panelCreateControl.GetComponent<PanelCreateControl>().buttonPrev.onClick.AddListener(this.ButtonPrev);



 

    }
    #endregion
    #region Function
    // Constructor
    // Public
    public void StartGame() {
        CharacterBuilder.CreateNewCharacter(createParams);

        // Start Game
        SceneBuilder.LoadScene(CharacterParam.param.sceneName, "LoadScreen");
    }
    public void OpenDefaultPanels() {
        CloseAllStepPanels();
        panelCreateControl = UIBuilder.OpenPanel("PanelCreateControl");
        panelStep1 = UIBuilder.OpenPanel("PanelCreateStep" + currentStep.ToString());

    }
    // Private
    private void ButtonPrev() {
        switch (currentStep) {
            case 2:
            CloseAllStepPanels();
            currentStep--;
            panelStep1 = UIBuilder.OpenPanel("PanelCreateStep" + currentStep.ToString());
            break;
            case 3:
            CloseAllStepPanels();
            currentStep--;
            panelStep2 = UIBuilder.OpenPanel("PanelCreateStep" + currentStep.ToString());
            break;
        }
    }
    private void ButtonNext() {
        switch (currentStep) {
            case 1:
            if (!panelStep1.GetComponent<PanelCreateStep1>().IsPanelValid()) {

                return;
            }
            // Set Create Params Step 1
            NewCharacterController.createParams.sex = panelStep1.GetComponent<PanelCreateStep1>().characterSex;
            NewCharacterController.createParams.name = panelStep1.GetComponent<PanelCreateStep1>().inputFieldName.text;
            // Open Next Step
            currentStep++;
            CloseAllStepPanels();
            panelStep2 = UIBuilder.OpenPanel("PanelCreateStep" + currentStep.ToString());
            break;
            case 2:
            if (!panelStep2.GetComponent<PanelCreateStep2>().IsPanelValid()) {

                return;
            }
            // Set Create Params Step 2
            NewCharacterController.createParams.historyName = panelStep2.GetComponent<PanelCreateStep2>().selectHistoryName;
            // Open Next Step
            CloseAllStepPanels();
            currentStep++;
            panelStep2 = UIBuilder.OpenPanel("PanelCreateStep" + currentStep.ToString());
            break;
            case 3:
            CloseAllStepPanels();
            // Start new Game
            StartGame();
            break;
        }
    }
    private void ButtonBack() {
        // Open Create New Character Scene
        SceneBuilder.LoadScene("Account", "LoadScreen");
    }
    private void CloseAllStepPanels() {
        UIBuilder.ClosePanel("PanelCreateStep1");
        UIBuilder.ClosePanel("PanelCreateStep2");
        UIBuilder.ClosePanel("PanelCreateStep3");
    }
    private void SelectHistory(string historyName) {
        // Set History Name
        NewCharacterController.createParams.historyName = historyName;
                                   
    }
    #endregion
    #region Events

    #endregion
    #region Button Events

    #endregion
    #region Structs
    public struct CreateCharacterParams {
        public string name;
        public string historyName;
        public PrivateParam.CharacterSex sex;

    }
    #endregion
    #region Enums

    #endregion
}