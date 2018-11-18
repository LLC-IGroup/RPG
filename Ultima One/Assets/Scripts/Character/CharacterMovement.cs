using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class CharacterMovement : MonoBehaviour {
    #region Fields
    // Private 
    [HideInInspector] private NavMeshAgent navMeshAgent;
    #endregion
    #region Unity Editor
    public void OnValidate() {
        
    }
    #endregion
    #region MonoBehaviour
    public void Awake() {
        // Set Params 
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.speed = CharacterParam.GetMoveSpeed();
    }
    public void Start() {
        
    }
    public void Update() {
        // Mouse Press Event
        if (!EventSystem.current.IsPointerOverGameObject() &&
            Input.GetMouseButtonUp(0)) {
            // Create RayCast
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Check ReayCast
            if (Physics.Raycast(ray, out hit, 1000))
                navMeshAgent.SetDestination(hit.point);
        }
    }
    #endregion
    #region Function
    // Public
    public bool IsMove() {
        if (navMeshAgent.destination != transform.position)
            return true;
        else return false;
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