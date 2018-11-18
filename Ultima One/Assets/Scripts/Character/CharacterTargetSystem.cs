using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterTargetSystem : MonoBehaviour {
    #region Fields
    // Public
    [HideInInspector] public GameObject mainTarget;
    [HideInInspector] public GameObject currentTarget;
    // Private
    [HideInInspector] private GameObject prevSelectTarget;
    [HideInInspector] private GameObject panelTargetPrefab;
    [HideInInspector] private GameObject panelTarget;
    #endregion
    #region Unity Editor
    public void OnValidate() {
        
    }
    #endregion
    #region MonoBehaviour
    public void Awake() {
        // Get Target Prefab
        panelTargetPrefab = Resources.Load<GameObject>("UI/PanelCharacterTarget");
    }
    public void Start() {
        
    }
    public void Update() {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        // Get Current Target
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) &&
            hit.transform.gameObject.GetComponent<BaseSceneObject>() != null) {
            OpenTargetPanel(hit.transform.gameObject.GetComponent<BaseSceneObject>());
            // Set Current Target
            currentTarget = hit.transform.gameObject;
        } else if (Physics.Raycast(ray, out hit) &&
            hit.transform.gameObject.GetComponent<BaseNPC>() != null) {
            OpenTargetPanel(hit.transform.gameObject.GetComponent<BaseNPC>());
            // Set Current Target
            currentTarget = hit.transform.gameObject;
        } else {
            currentTarget = null;
            CloseTrargetPanel();
        }
    }
    #endregion
    #region Function
    // Public
    // Private
    private void OpenTargetPanel(BaseSceneObject sceneObject) {
        if (panelTarget != null)
            Destroy(panelTarget);
        panelTarget = Instantiate(panelTargetPrefab, UIBuilder.GetCanvasTransform());
        panelTarget.GetComponent<PanelCharacterTarget>().SetParam(sceneObject);
    }
    private void OpenTargetPanel(BaseNPC baseNPC) {
        if (panelTarget != null)
            Destroy(panelTarget);
        panelTarget = Instantiate(panelTargetPrefab, UIBuilder.GetCanvasTransform());
        panelTarget.GetComponent<PanelCharacterTarget>().SetParam(baseNPC);
    }
    private void CloseTrargetPanel() {
        if (panelTarget != null)
            Destroy(panelTarget);
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