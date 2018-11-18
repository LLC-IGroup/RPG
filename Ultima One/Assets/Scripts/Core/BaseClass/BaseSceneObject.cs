using System;
using UnityEngine;

public class BaseSceneObject : MonoBehaviour {
    #region Fields
    // Public
    [HideInInspector] public string sceneObjectName;
    [HideInInspector] public string sceneObjectGameName;
    [HideInInspector] public string description;
    [HideInInspector] public string iconName;
    [HideInInspector] public uint quality;
    [HideInInspector] public uint HP;

    #endregion
    #region MonoBehaviour
    virtual public void OnValidate () {


    }
    virtual public void Awake() {


    }
    virtual public void Start() {


    }
    #endregion
    #region Function
    // Public
    public ItemInventory GetItemInventory() {
        if (this is BarrelObject) {
            BarrelObject barrelObject = this as BarrelObject;
            return barrelObject.itemInventory;
        }
        return null;
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