using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelHistoryCell : BaseCellPanel {
    #region Fields
    // Public
    [SerializeField] public Image imageSellect;
    [SerializeField] public Button buttonBody;
    [SerializeField] public Button buttonFullDescription;
    [SerializeField] public Text textHistoryName;
    [SerializeField] public Text textHistory;
    [HideInInspector] public string historyName;
    // Static
    [HideInInspector] static public Action<string> Select;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        base.OnValidate();

    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        base.Awake();
        buttonBody.onClick.AddListener(this.SelectHistory);
    }
    override public void Start() {
        base.Start();
        
    }
    #endregion
    #region Function
    // Public
    public void SetParam(string historyName, string history) {
        // Set Text
        textHistory.text = history;
        textHistoryName.text = historyName;
        this.historyName = historyName;
    }
    public void SelectCell() {
        imageSellect.gameObject.SetActive(true);
    }
    public void UnSelect() {
        imageSellect.gameObject.SetActive(false);
    }
    // Private
    private void SelectHistory() {
        // Sellect Action
        Select?.Invoke(historyName);
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