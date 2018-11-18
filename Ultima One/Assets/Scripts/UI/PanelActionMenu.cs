using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelActionMenu : BasePanel {
    #region Fields
    [SerializeField] public GameObject panelContent;
    [SerializeField] public GameObject actionCellPrefab;
    // Private
    [HideInInspector] private uint offSet;
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
        offSet = 30;
        panelName = "PanelActionMenu";
        SetDrag(false);
    }
    override public void Start() {
        base.Start();


    }
    #endregion
    #region Function
    // Public
    public void SetParam(GameObject currentTarget) {
        // Offset Count
        uint offsetCount = 0;
        // Clear Content
        RemoveAllChildren(panelContent);
        if (currentTarget.GetComponent<BaseNPC>() != null) {
            BaseNPC baseNPC = currentTarget.GetComponent<BaseNPC>();
            // Create Action Cell
            GameObject loockCell = Instantiate<GameObject>(actionCellPrefab, panelContent.transform);
            loockCell.GetComponent<PanelActionCell>().SetParam("Loock", currentTarget);
            offsetCount++;
            if (baseNPC.NPCParam.agresion >= 0) {
                // Talk
                GameObject talkCell = Instantiate<GameObject>(actionCellPrefab, panelContent.transform);
                talkCell.GetComponent<PanelActionCell>().SetParam("Talk", currentTarget);
                offsetCount++;
                // Trade
                GameObject tradeCell = Instantiate<GameObject>(actionCellPrefab, panelContent.transform);
                tradeCell.GetComponent<PanelActionCell>().SetParam("Trade", currentTarget);
                offsetCount++;
            }
            GameObject stealCell = Instantiate<GameObject>(actionCellPrefab, panelContent.transform);
            stealCell.GetComponent<PanelActionCell>().SetParam("Steal", currentTarget);
            offsetCount++;
            
        }
        if (currentTarget.GetComponent<BaseSceneObject>() != null) {
            // Create Action Cell
            GameObject loockCell = Instantiate<GameObject>(actionCellPrefab, panelContent.transform);
            loockCell.GetComponent<PanelActionCell>().SetParam("Loock", currentTarget);
            offsetCount++;
            /// Tree Object
            if (currentTarget.GetComponent<TreeObject>() != null) {
                TreeObject treeObject = currentTarget.GetComponent<TreeObject>();
                // Get Hurvest
                GameObject hurvestCell = Instantiate<GameObject>(actionCellPrefab, panelContent.transform);
                hurvestCell.GetComponent<PanelActionCell>().SetParam("Hurvest", currentTarget);
                offsetCount++;
                // Get Sticks
                GameObject stickCell = Instantiate<GameObject>(actionCellPrefab, panelContent.transform);
                stickCell.GetComponent<PanelActionCell>().SetParam("GetStick", currentTarget);
                offsetCount++;
                // Cut
                GameObject cutCell = Instantiate<GameObject>(actionCellPrefab, panelContent.transform);
                cutCell.GetComponent<PanelActionCell>().SetParam("CutTree", currentTarget);
                offsetCount++;
            }
            /// Barrel Object
            if (currentTarget.GetComponent<BarrelObject>() != null) {
                // Open
                GameObject cutCell = Instantiate<GameObject>(actionCellPrefab, panelContent.transform);
                cutCell.GetComponent<PanelActionCell>().SetParam("Open", currentTarget);
                offsetCount++;
            }
        }
        // Set Panel Height
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(rectTransform.rect.width, rectTransform.rect.height + (offsetCount * offSet));
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