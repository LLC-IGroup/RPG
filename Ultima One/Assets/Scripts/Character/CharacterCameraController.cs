using UnityEngine;

public class CharacterCameraController : MonoBehaviour {
    #region Fields
    // Public
    [SerializeField] public Transform loockPoint;
    // Private
    [HideInInspector] private new Camera camera;
    [HideInInspector] private float currentDistance;
    [HideInInspector] private float x;
    [HideInInspector] private float y;
    #endregion
    #region Unity Editor
    public void OnValidate() {
        
    }
    #endregion
    #region MonoBehaviour
    public void Awake() {
        // Get Camera Script
        camera = Camera.main;
        // Set Default Params 
        x = 0.0f;
        y = 0.0f;
    }
    public void Start() {
        x += Input.GetAxis("Mouse X") * GameParams.cameraSpeedX;
        y -= Input.GetAxis("Mouse Y") * GameParams.cameraSpeedY;

        currentDistance = GameParams.cameraMinDistance;
        currentDistance -= (Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime) * currentDistance * Mathf.Abs(currentDistance);
        currentDistance = Mathf.Clamp(currentDistance, GameParams.cameraMinDistance, GameParams.cameraMaxDistance);
        y = ClampAngle(y, GameParams.cameraMinAngle, GameParams.cameraMaxAngle);

        Quaternion rotation = Quaternion.Euler(y, x, 0);
        camera.transform.rotation = rotation;
        Vector3 position = rotation * new Vector3(0.0f, 0.0f, -currentDistance) + loockPoint.position;
        camera.transform.position = position;
    }
    public void FixedUpdate() {
        // Zoom
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && currentDistance > GameParams.cameraMinDistance) {
            currentDistance -= 0.5f;

        } else if (Input.GetAxis("Mouse ScrollWheel") < 0 && currentDistance < GameParams.cameraMaxDistance) {
            currentDistance += 0.5f;
        }
        // Rotation
        if (Input.GetMouseButton(1)) {
            x += Input.GetAxis("Mouse X") * GameParams.cameraSpeedX;
            y -= Input.GetAxis("Mouse Y") * GameParams.cameraSpeedX;

            currentDistance -= (Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime) * currentDistance * Mathf.Abs(currentDistance);
            currentDistance = Mathf.Clamp(currentDistance, GameParams.cameraMinDistance, GameParams.cameraMaxDistance);
            y = ClampAngle(y, GameParams.cameraMinAngle, GameParams.cameraMaxAngle);

            Quaternion rotation = Quaternion.Euler(y, x, 0);
            camera.transform.rotation = rotation;
            Vector3 position = rotation * new Vector3(0.0f, 0.0f, -currentDistance) + loockPoint.position;
            camera.transform.position = position;
            // Collision
            RaycastHit hit;
            if (Physics.Linecast(loockPoint.transform.position, camera.transform.position, out hit)) {
                float tempDistance = Vector3.Distance(loockPoint.transform.position, hit.point);
                position = loockPoint.position - (rotation * Vector3.forward * tempDistance + new Vector3(0, 0, 0));
                camera.transform.position = position;
            }
        } else {
            Vector3 position = camera.transform.rotation * new Vector3(0.0f, 0.0f, -currentDistance) + loockPoint.position;
            camera.transform.position = position;
        }
    }
    #endregion
    #region Function
    // Public
    // Private
    private float ClampAngle(float angle, float min, float max) {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
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