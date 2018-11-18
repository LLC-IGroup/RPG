using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BasePanel : MonoBehaviour,
    IBeginDragHandler, IDragHandler, IEndDragHandler {
    #region Fields
    // Public
    [SerializeField] public Button[] buttonCloseArray;
    [HideInInspector] public string panelName;
    // Private 
    [HideInInspector] private bool isDrag;
    #endregion
    #region Unity Editor
    virtual public void OnValidate() {
        
    }
    #endregion
    #region MonoBehaviour
    virtual public void Awake() {
        // Set Params
        isDrag = false;
        for (int i = 0; i < buttonCloseArray.Length; i++)
            buttonCloseArray[i].onClick.AddListener(this.ClosePanel);

    }
    virtual public void Start() {
            
    }
    #endregion
    #region Function
    virtual public void UpdatePanel() {

    }
    virtual public void ClosePanel() {
        UIBuilder.ClosePanel(panelName);
        
    }
    // Public
    public void SetDrag(bool isDrag) => this.isDrag = isDrag;
    // Protected
    protected void RemoveAllChildren(GameObject bodyObject) {
        foreach (Transform childTransform in bodyObject.transform)
            Destroy(childTransform.gameObject);
    }
    // Private
    #endregion
    #region Events
    public void OnBeginDrag(PointerEventData eventData) {

    }
    public void OnDrag(PointerEventData eventData) {
        if (isDrag) {
            // Set Drag Position
            transform.position += (Vector3)eventData.delta;
        }
    }
    public void OnEndDrag(PointerEventData eventData) {
        UIBuilder.SetTopZIndexPanel(panelName);
    }
    #endregion
    #region Button Events

    #endregion
    #region Structs

    #endregion
    #region Enums

    #endregion
}      