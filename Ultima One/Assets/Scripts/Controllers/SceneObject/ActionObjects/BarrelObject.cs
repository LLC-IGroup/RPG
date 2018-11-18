using UnityEngine;

public class BarrelObject : BaseSceneObject {
    #region Fields
    // Public
    [HideInInspector] public ItemInventory itemInventory;
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
        sceneObjectName = "Barrel";
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