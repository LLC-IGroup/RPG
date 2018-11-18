using UnityEngine;
using UnityEngine.AI;

public class GuardNPC : BaseNPC {
    #region Fields
    // Private 
    [HideInInspector] private NavMeshAgent navMeshAgent;
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
        moveSpeed = 3.0f;
        NPCModel = Resources.Load<GameObject>("NPCModel");


        // Debug
        DialogNode dialogNode = new DialogNode();
        dialogNode.dialogText = "Guart Text";
        dialogSystem.rootNode = dialogNode;

    }
    override public void Start() {
        base.Start();
        
    }
    #endregion
    #region Function
    // Public
    public void SetParam(NavMeshAgent navMeshAgent) {
        // Move Speed
        this.navMeshAgent = navMeshAgent;
        navMeshAgent.speed = moveSpeed;
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