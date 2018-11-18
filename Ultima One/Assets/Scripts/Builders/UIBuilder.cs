using System;
using System.Collections.Generic;
using UnityEngine;

sealed public class UIBuilder {
    #region Fields
    // Private 
    static private List<GameObject> listPanel = new List<GameObject>();
    static private Transform canvasTransform = null;
    #endregion
    #region Function
    static public Transform GetCanvasTransform() {
        if (canvasTransform == null)
            canvasTransform = GameObject.FindGameObjectWithTag("Canvas").transform;
        if (canvasTransform == null) {
#if UNITY_EDITOR
            Debug.LogError("Can't Find Canvas Transform");
#endif
        }
        return canvasTransform;
    }
    static public GameObject OpenPanel(string prefabPanelName) {
        // Get Canvas Object
        canvasTransform = GetCanvasTransform();
        if (canvasTransform == null) {
#if UNITY_EDITOR
            Debug.LogError("Can't Canvas Transform is null");
#endif
            return null;
        } else {
            // Try Find Resources
            GameObject panel = Resources.Load<GameObject>("UI/" + prefabPanelName);
            if (panel == null) {
#if UNITY_EDITOR
                Debug.LogError("Can't Find Prefab " + prefabPanelName + " in Resources/UI/");
#endif
            }
            // Instantiate Panel 
            panel = GameObject.Instantiate(panel, canvasTransform);
            // Add Panel to list
            listPanel.Add(panel);
            return panel;
        }
    }
    static public void ClosePanel(string panelName) {
        GameObject temp = null;
        foreach (GameObject panel in listPanel)
            if (panel.name.Equals(panelName + "(Clone)"))
                temp = panel;
        if (temp != null) {
            listPanel.Remove(temp);
            GameObject.Destroy(temp);
        }
    }
    static public void UpdateAllPanels() {
        foreach (GameObject panel in listPanel)
            panel.GetComponent<BasePanel>().UpdatePanel();
    }
    static public void CloseAllPanel() {
        foreach (GameObject panel in listPanel)
            GameObject.Destroy(panel);
        listPanel.Clear();
    }
    static public GameObject GetPanel(string panelName) {
        foreach (GameObject panel in listPanel)
            if (panel.name.Equals(panelName + "(Clone)"))
                return panel;
        return null;
    }
    static public void SetTopZIndexPanel(string panelName) {
        Transform panel = GetPanel(panelName).transform;
        Transform parent = panel.transform.parent;
        if (panel != null) {
            // Remove Parant
            panel.transform.SetParent(null);
            // Set Parant
            panel.transform.SetParent(parent);
        }
    }
    static public bool IsOpen(string panelName) {
        foreach (GameObject panel in listPanel)
            if (panel.name.Equals(panelName + "(Clone)"))
                return true;
        return false;
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