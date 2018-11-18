using System.Collections.Generic;
using UnityEngine;

public class TreeObject : BaseSceneObject {
    #region Fields
    // Public
    [HideInInspector] public ItemInventory dropInventory;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        base.OnValidate();

    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        base.Awake();
        // Set Param
        sceneObjectName = "Tree";
        SceneObjectBuilder.GetObjectByName(GetComponent<BaseSceneObject>());

    }
    override public void Start() {
        base.Start();


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