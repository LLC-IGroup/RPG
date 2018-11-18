using UnityEngine;

public class SandBoxController : BaseScene {
    #region Fields
    // Public
    [SerializeField] public Transform startPoint;
    // Private
    [HideInInspector] GameObject character;
    [HideInInspector] GameObject[] listNPC;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        base.OnValidate();

    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        base.Awake();

    }
    override public void Start() {
        base.Start();
        musicController.GetComponent<AudioSource>().Stop();
        // Get All Scene NPC
        listNPC = GameObject.FindGameObjectsWithTag("NPC");
        // Create Character In Start Point
        character = Instantiate(characterPrefab, startPoint);


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