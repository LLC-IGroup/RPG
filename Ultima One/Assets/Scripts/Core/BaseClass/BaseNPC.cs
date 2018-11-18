using UnityEngine;

public class BaseNPC : MonoBehaviour {
    #region Fields
    // Public
    [SerializeField] public GameObject NPCModelPrefab;
    [SerializeField] public RuntimeAnimatorController NPCAnimator;

    [HideInInspector] public NPCParam NPCParam;
    [HideInInspector] public DialogSystem dialogSystem;
    [HideInInspector] public string gameName;
    
    //Protected
    [HideInInspector] protected float moveSpeed;
    [HideInInspector] protected GameObject NPCModel;
    #endregion
    #region Unity Editor
    virtual public void OnValidate() {
        
    }
    #endregion
    #region MonoBehaviour
    virtual public void Awake() {
        // Set Param
        NPCParam = new NPCParam();
        dialogSystem = new DialogSystem();
        // Instantiate Model
        NPCModel = Instantiate<GameObject>(NPCModelPrefab, gameObject.transform);
        NPCModel.GetComponent<Animator>().runtimeAnimatorController = NPCAnimator;

    }
    virtual public void Start() {
        
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