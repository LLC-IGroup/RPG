using System;
using System.Collections;
using UnityEngine;

public class CharacterAction : MonoBehaviour {
    #region Fields
    // Public
    [SerializeField] public GameObject panelActionPrefab;
    // Private
    [HideInInspector] private bool isAction;
    [HideInInspector] private GameObject panelNPCDialog;
    [HideInInspector] private GameObject panelAction;
    #endregion
    #region Unity Editor
    public void OnValidate() {

    }
    #endregion
    #region MonoBehaviour
    public void Awake() {
        // Set Actions
        BaseCellPanel.DragAndDrop += this.ActionCellDrop;
        PanelActionCell.ActionCell += this.ActionMenu;
    }
    public void Start() {

    }
    public void Update() {
        // Open Action Target Menu
        if (Input.GetMouseButtonUp(1)) {
            GameObject currentTarget = GetComponent<CharacterTargetSystem>().currentTarget;
            if (currentTarget != null) {
                UIBuilder.ClosePanel("PanelActionMenu");
                GameObject panelActionMenu = UIBuilder.OpenPanel("PanelActionMenu");
                panelActionMenu.transform.position = Input.mousePosition;
                panelActionMenu.gameObject.SetActive(true);
                panelActionMenu.GetComponent<PanelActionMenu>().SetParam(currentTarget);

            }
        }
        // Cloase Action Target Menu
        if (Input.GetMouseButtonDown(1) ||
            GetComponent<CharacterMovement>().IsMove())
            UIBuilder.ClosePanel("PanelActionMenu");
        if (Input.GetMouseButtonUp(0))
            UIBuilder.ClosePanel("PanelActionMenu");
    }
    #endregion
    #region Function
    // Public
    // Private
    private void DropCellToHotBar(DragAndDropParam dragAndDropParam) {
        HotBarCell hotBarCell = dragAndDropParam.dragCell as HotBarCell;
        hotBarCell.baseCell = dragAndDropParam.dropCell;
        UIBuilder.UpdateAllPanels();
    }
    private void EquipItemFromICharacterInventory(DragAndDropParam dragAndDropParam) {
        EquipCell equipCell = dragAndDropParam.dragCell as EquipCell;
        ItemCell itemCell = dragAndDropParam.dropCell as ItemCell;
        equipCell.item = itemCell.item;
        CharacterParam.itemInventory.RemoveItem(itemCell.item);
        // Update Chaeacre Param
        CharacterParam.UpadateParam(itemCell.item);
        // Update All Panels
        UIBuilder.UpdateAllPanels();
    }
    private void EquipItemFromIBoxInventory(DragAndDropParam dragAndDropParam) {
        EquipCell equipCell = dragAndDropParam.dragCell as EquipCell;
        ItemCell itemCell = dragAndDropParam.dropCell as ItemCell;
        equipCell.item = itemCell.item;
        PanelBoxInventory panelBoxInventory = dragAndDropParam.dragFromPanel.GetComponent<PanelBoxInventory>();
        panelBoxInventory.sceneObject.GetItemInventory().RemoveItem(itemCell.item);
        // Update Character Param
        CharacterParam.UpadateParam(itemCell.item);
        // Update Box Inventory Panel
        panelBoxInventory.UpdatePanel(panelBoxInventory.sceneObject);
        // Update All Panels
        UIBuilder.UpdateAllPanels();
    }
    private void UnEquipItemToCharacterInventory(DragAndDropParam dragAndDropParam) {
        EquipCell equipCell = dragAndDropParam.dropCell as EquipCell;
        ItemCell itemCell = dragAndDropParam.dropCell as ItemCell;
        if (itemCell != null) {
            Debug.Log("Drop to stuck");

        } else {
            CharacterParam.itemInventory.AddItem(equipCell.item);
            // Update Character Param
            CharacterParam.UpadateParam(equipCell.item);
            equipCell.item = null;
        }
        // Update All Panels
        UIBuilder.UpdateAllPanels();
    }
    private void UnEquipItemToBoxInventory(DragAndDropParam dragAndDropParam) {
        EquipCell equipCell = dragAndDropParam.dropCell as EquipCell;
        ItemCell itemCell = dragAndDropParam.dropCell as ItemCell;
        PanelBoxInventory panelBoxInventory = dragAndDropParam.dragToPanel.GetComponent<PanelBoxInventory>();
        if (itemCell != null) {
            Debug.Log("Drop to stuck");

        } else {
            panelBoxInventory.sceneObject.GetItemInventory().AddItem(equipCell.item);
            // Update Character Param
            CharacterParam.UpadateParam(equipCell.item);
            equipCell.item = null;
        }
        // Update Box Inventory Panel
        panelBoxInventory.UpdatePanel(panelBoxInventory.sceneObject);
        // Update All Panels
        UIBuilder.UpdateAllPanels();

    }
    private void DropToCharacterInventoryFromBoxInventory(DragAndDropParam dragAndDropParam) {
        ItemCell itemCellInventory = dragAndDropParam.dragCell as ItemCell;
        ItemCell itemCellBox = dragAndDropParam.dropCell as ItemCell;
        PanelBoxInventory panelBoxInventory = dragAndDropParam.dragFromPanel.GetComponent<PanelBoxInventory>();
        if (itemCellInventory != null) {
            Debug.Log("Drop to stuck");

        } else {
            ItemInventory itemInventory = panelBoxInventory.sceneObject.GetItemInventory();
            for (int i = 0; i < itemCellBox.count; i++) {
                if (!CharacterParam.itemInventory.AddItem(itemCellBox.item))
                    break;
                itemInventory.RemoveItem(itemCellBox.item);
            }
        }
        // Update Box Inventory Panel
        panelBoxInventory.UpdatePanel(panelBoxInventory.sceneObject);
        // Update All Panels
        UIBuilder.UpdateAllPanels();
    }
    private void DropToBoxinventoryFromCharacterInventory(DragAndDropParam dragAndDropParam) {
        ItemCell itemCellInventory = dragAndDropParam.dragCell as ItemCell;
        ItemCell itemCellBox = dragAndDropParam.dropCell as ItemCell;
        PanelBoxInventory panelBoxInventory = dragAndDropParam.dragToPanel.GetComponent<PanelBoxInventory>();
        if (itemCellInventory != null) {
            Debug.Log("Drop to stuck");

        } else {
            ItemInventory itemInventory = panelBoxInventory.sceneObject.GetItemInventory();
            for (int i = 0; i < itemCellBox.count; i++) {
                if (!itemInventory.AddItem(itemCellBox.item))
                    break;
                CharacterParam.itemInventory.RemoveItem(itemCellBox.item);
            }
        }
        // Update Box Inventory Panel
        panelBoxInventory.UpdatePanel(panelBoxInventory.sceneObject);
        // Update All Panels
        UIBuilder.UpdateAllPanels();
    }
    #endregion
    #region Events
    private void ActionMenu(ActionCellParam actionCellParam) {
        // NPC
        if (actionCellParam.NPC != null &&
        actionCellParam.NPC.GetComponent<BaseNPC>() != null) {
            if (Vector3.Distance(actionCellParam.NPC.transform.position, gameObject.transform.position) > GameParams.actionDistance) {
                ChatParam.AddMSG("You too far");
                return;
            }
            switch (actionCellParam.actionName) {
                case "Loock":
                ChatParam.AddMSG("You loock at: " + actionCellParam.NPC.NPCParam.privateParams.name);
                break;
                case "Talk":
                // Cloase Prev Panel
                UIBuilder.ClosePanel("PanelNPCDialog");
                // Open New NPC Dialog Panel
                GameObject NPCDialog = UIBuilder.OpenPanel("PanelNPCDialog");
                PanelNPCDialog panelNPCDialog = NPCDialog.GetComponent<PanelNPCDialog>();
                panelNPCDialog.SetParam(actionCellParam.NPC.GetComponent<BaseNPC>());
                break;
            }
        }
        // Scene Object
        if (actionCellParam.sceneObject != null &&
        actionCellParam.sceneObject.GetComponent<BaseSceneObject>() != null) {
            if (Vector3.Distance(actionCellParam.sceneObject.transform.position, gameObject.transform.position) > GameParams.actionDistance) {
                ChatParam.AddMSG("You too far");
                return;
            }
            switch (actionCellParam.actionName) {
                case "Loock":
                ChatParam.AddMSG("Description: " + actionCellParam.sceneObject.description);
                break;
                case "Hurvest":

                break;
                case "GetStick":

                break;
                case "CutTree":

                break;
                case "Open":
                // Close Pld Panel
                UIBuilder.ClosePanel("PanelBoxInventory");
                // Open Box Inventory Panel
                GameObject panelBoxInventory = UIBuilder.OpenPanel("PanelBoxInventory");
                panelBoxInventory.GetComponent<PanelBoxInventory>().UpdatePanel(actionCellParam.sceneObject);
                break;
            }
        }
        UIBuilder.ClosePanel("PanelActionMenu");
        UIBuilder.UpdateAllPanels();
    }
    private void ActionCellDrop(DragAndDropParam dragAndDropParam) {
        // Stop Prev Action
        StopAllCoroutines();
        /// Hot Bar
        if (dragAndDropParam.dragToPanel != null &&
            dragAndDropParam.dragToPanel.panelName == "PanelHotBar") {
            // Drop Cell
            if (dragAndDropParam.dropCell == null)
                return;
            // Create Action
            StartCoroutine(StartAction(0, dragAndDropParam, this.DropCellToHotBar));
        }
        /// Equip from Character Inventory
        if (dragAndDropParam.dragToPanel != null &&
            dragAndDropParam.dragToPanel.panelName == "PanelCharacter" &&
            dragAndDropParam.dragFromPanel != null &&
            dragAndDropParam.dragFromPanel.panelName == "PanelCharacterInventory") {
            if (dragAndDropParam.dropCell is EquipCell) {
                // Drop Cell
                if (dragAndDropParam.dropCell == null ||
                    dragAndDropParam.dropCell.baseCell != null)
                    return;
                EquipCell equipCell = dragAndDropParam.dropCell as EquipCell;
                ItemCell itemCell = dragAndDropParam.dragCell as ItemCell;
                // Cell Not Empty
                if (equipCell.equipType != itemCell.item.itemType ||
                    equipCell.item != null)
                    return;
                // Create Action
                StartCoroutine(StartAction(GameParams.equipTime, dragAndDropParam, this.EquipItemFromICharacterInventory));
            }
        }
        /// Equip from Box Inventory
        if (dragAndDropParam.dragToPanel != null &&
            dragAndDropParam.dragToPanel.panelName == "PanelCharacter" &&
            dragAndDropParam.dragFromPanel != null &&
            dragAndDropParam.dragFromPanel.panelName == "PanelBoxInventory") {
            if (dragAndDropParam.dropCell is EquipCell) {
                // Drop Cell
                if (dragAndDropParam.dropCell == null ||
                    dragAndDropParam.dropCell.baseCell != null)
                    return;
                EquipCell equipCell = dragAndDropParam.dropCell as EquipCell;
                ItemCell itemCell = dragAndDropParam.dragCell as ItemCell;
                // Cell Not Empty
                if (equipCell.equipType != itemCell.item.itemType ||
                    equipCell.item != null)
                    return;
                // Create Action
                StartCoroutine(StartAction(GameParams.equipTime, dragAndDropParam, this.EquipItemFromIBoxInventory));
            }
        }
        /// UnEquip to Character Inventory
        if (dragAndDropParam.dragToPanel != null &&
        dragAndDropParam.dragToPanel.panelName == "PanelCharacterInventory" &&
        dragAndDropParam.dragFromPanel != null &&
        dragAndDropParam.dragFromPanel.panelName == "PanelCharacter") {
            EquipCell equipCell = dragAndDropParam.dragCell as EquipCell;
            // Full Inventory
            if (!CharacterParam.itemInventory.IsAdd(equipCell.item))
                return;
            StartCoroutine(StartAction(GameParams.equipTime, dragAndDropParam, this.UnEquipItemToCharacterInventory));
        }
        /// UnEquip to Box Inventory
        if (dragAndDropParam.dragToPanel != null &&
        dragAndDropParam.dragToPanel.panelName == "PanelBoxInventory" &&
        dragAndDropParam.dragFromPanel != null &&
        dragAndDropParam.dragFromPanel.panelName == "PanelCharacter") {
            EquipCell equipCell = dragAndDropParam.dragCell as EquipCell;
            PanelBoxInventory panelBoxInventory = dragAndDropParam.dragToPanel.GetComponent<PanelBoxInventory>();
            // Full Inventory
            if (!panelBoxInventory.sceneObject.GetItemInventory().IsAdd(equipCell.item))
                return;
            StartCoroutine(StartAction(GameParams.equipTime, dragAndDropParam, this.UnEquipItemToBoxInventory));
        }
        /// Drop from Box Inventory to Character Inventory
        if (dragAndDropParam.dragFromPanel != null &&
        dragAndDropParam.dragFromPanel.panelName == "PanelBoxInventory" &&
        dragAndDropParam.dragToPanel != null &&
        dragAndDropParam.dragToPanel.panelName == "PanelCharacterInventory") {
            ItemCell itemCell = dragAndDropParam.dragCell as ItemCell;
            // Full Inventory
            if (!CharacterParam.itemInventory.IsAdd(itemCell.item))
                return;
            StartCoroutine(StartAction(GameParams.equipTime, dragAndDropParam, this.DropToCharacterInventoryFromBoxInventory));
        }
        /// Drop from Character Inventory to Box Inventory
        if (dragAndDropParam.dragFromPanel != null &&
            dragAndDropParam.dragFromPanel.panelName == "PanelCharacterInventory" &&
            dragAndDropParam.dragToPanel != null &&
            dragAndDropParam.dragToPanel.panelName == "PanelBoxInventory") {
            ItemInventory itemInventory = dragAndDropParam.dragToPanel.GetComponent<PanelBoxInventory>().sceneObject.GetItemInventory();
            ItemCell itemCell = dragAndDropParam.dragCell as ItemCell;
            // Full Inventory
            if (!itemInventory.IsAdd(itemCell.item))
                return;
            StartCoroutine(StartAction(GameParams.equipTime, dragAndDropParam, this.DropToBoxinventoryFromCharacterInventory));
        }
    }
    #endregion
    #region Coroutine
    private IEnumerator StartAction(float actionTime,
        DragAndDropParam dragAndDropParam,
        Action<DragAndDropParam> action) {
        BaseCell dropCell = dragAndDropParam.dragCell;
        BaseCell dragCell = dragAndDropParam.dropCell;
        BasePanel dragFromPanel = dragAndDropParam.dragFromPanel;
        BasePanel dragToPanel = dragAndDropParam.dragToPanel;
        isAction = true;
        if (actionTime <= 0)
            isAction = false;
        // Cloase Old Panel
        if (panelAction != null)
            Destroy(panelAction);
        // Create Action Panel
        panelAction = Instantiate(panelActionPrefab, UIBuilder.GetCanvasTransform());
        float actionDelta = actionTime;
        while (isAction) {
            actionDelta -= Time.deltaTime;
            if (actionDelta <= 0)
                isAction = false;
            // Get Action Time
            float percent = actionTime / 100;
            float doneTime = actionTime - actionDelta;
            float timer = (doneTime / percent) / 100;
            panelAction.GetComponent<PanelAction>().SetTimer(timer);
            yield return null;
        }
        Destroy(panelAction);
        dragAndDropParam.dragCell = dragCell;
        dragAndDropParam.dropCell = dropCell;
        dragAndDropParam.dragToPanel = dragToPanel;
        dragAndDropParam.dragFromPanel = dragFromPanel;
        action?.Invoke(dragAndDropParam);
        isAction = false;
    }
    #endregion
    #region Structs

    #endregion
    #region Enums

    #endregion
}