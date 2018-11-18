using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScreenController : MonoBehaviour {
    #region Fields
    [SerializeField] public Image imageBG;
    [HideInInspector] private List<Sprite> listBG;
    #endregion
    #region Unity Editor
    public void OnValidate() {
        
    }
    #endregion
    #region MonoBehaviour
    public void Awake() {
        // Set Params
        listBG = new List<Sprite>();
        listBG.Add(Resources.Load<Sprite>("Images/Load1"));
        listBG.Add(Resources.Load<Sprite>("Images/Load2"));
        listBG.Add(Resources.Load<Sprite>("Images/Load3"));


    }
    public void Start() {
        int BGcount = Random.Range(1, 3);
        imageBG.sprite = listBG.ToArray()[BGcount];

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