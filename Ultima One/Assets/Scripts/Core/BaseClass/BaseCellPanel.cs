using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BaseCellPanel : MonoBehaviour,
    IBeginDragHandler, IDragHandler, IEndDragHandler {
    #region Fields
    // Action 
    [HideInInspector] static public Action<DragAndDropParam> DragAndDrop;
    // Public
    [SerializeField] public GameObject dragCellPrefab;
    [HideInInspector] public bool isDrag;
    [HideInInspector] public BaseCell baseCell;
    // Private
    [HideInInspector] private DragAndDropParam dragAndDropParam;
    // Protected
    [HideInInspector] protected GameObject panelDragCell;
    [HideInInspector] protected BasePanel rootPanel;
    #endregion
    #region Unity Editor
    virtual public void OnValidate() {

    }
    #endregion
    #region MonoBehaviour
    virtual public void Awake() {
        // Set Params
        baseCell = new BaseCell();
        dragAndDropParam = new DragAndDropParam();
        isDrag = false;

    }
    virtual public void Start() {

    }
    virtual public void Update() {

    }
    #endregion
    #region Function
    // Virtual
    public void SetParam(BaseCell baseCell, BasePanel rootPanel) {
        this.rootPanel = rootPanel;
        this.baseCell = baseCell;
    }
    // Private
    #endregion
    #region Events
    public void OnBeginDrag(PointerEventData eventData) {
        if (!isDrag)
            return;
        // Create Drag Cell
        panelDragCell = Instantiate(dragCellPrefab, transform.root);
        panelDragCell.GetComponent<PanelDragCell>().SetParam(baseCell, null);
        panelDragCell.transform.position = transform.position;
    }
    public void OnDrag(PointerEventData eventData) {
        if (!isDrag || panelDragCell == null)
            return;
        // Set Drag Position
        panelDragCell.gameObject.transform.position += (Vector3)eventData.delta;
    }
    public void OnEndDrag(PointerEventData eventData) {
        if (!isDrag || panelDragCell == null)
            return;
        // Ray Cast UI Panels
        PointerEventData pointerData = new PointerEventData(EventSystem.current);
        pointerData.position = Input.mousePosition;
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);
        // Get Drop Body
        foreach (RaycastResult result in results) {
            if (result.gameObject.tag == "DropBody") {
                // Set Drag And Drop Params
                dragAndDropParam.dragToPanel = result.gameObject.transform.parent.GetComponent<BasePanel>();
                dragAndDropParam.dragFromPanel = rootPanel.GetComponent<BasePanel>();
                dragAndDropParam.dragCell = baseCell;
                break;
            }
        }
        foreach (RaycastResult rayResult in results) {
            if (rayResult.gameObject.GetComponent<BaseCellPanel>() != null) {
                dragAndDropParam.dropCell = rayResult.gameObject.GetComponent<BaseCellPanel>().baseCell;
                break;
            }
        }
        DragAndDrop?.Invoke(dragAndDropParam);
        dragAndDropParam.Clear();      
        Destroy(panelDragCell);
    }
    #endregion
    #region Button Events

    #endregion
    #region Structs

    #endregion
    #region Enums

    #endregion
}