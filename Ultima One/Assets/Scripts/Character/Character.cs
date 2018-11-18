using UnityEngine;

public class Character : MonoBehaviour {
    #region Fields
    // Public
    [SerializeField] public GameObject maleModel;
    [SerializeField] public RuntimeAnimatorController maleAnimatorController;
    [SerializeField] public GameObject femaleModel;
    [SerializeField] public RuntimeAnimatorController femaleAnimatorController;
    // Private
    [HideInInspector] private GameObject characterModel;
    #endregion
    #region Unity Editor
    public void OnValidate() {
        
    }
    #endregion
    #region MonoBehaviour
    public void Awake() {
        // Set Sex Param
        switch (CharacterParam.privateParams.sex) {
            case PrivateParam.CharacterSex.MALE:
            characterModel = Instantiate(maleModel, transform);
            characterModel.GetComponent<Animator>().runtimeAnimatorController = maleAnimatorController;

            break;
            case PrivateParam.CharacterSex.FEMALE:
            characterModel = Instantiate(femaleModel, transform);
            characterModel.GetComponent<Animator>().runtimeAnimatorController = femaleAnimatorController;

            break;
        }




    }
    public void Start() {
        OpenDefaultPanels();
    }
    public void Update() {
        // Param
        // Animation
        if (GetComponent<CharacterMovement>().IsMove()) {
            characterModel.GetComponent<Animator>().SetBool("IsMove", true);
        } else
            characterModel.GetComponent<Animator>().SetBool("IsMove", false);


    }
    #endregion
    #region Function
    // Public
    public void OpenDefaultPanels() {
        UIBuilder.OpenPanel("PanelHotBar");
        UIBuilder.OpenPanel("PanelCharacterAvatar");
        UIBuilder.OpenPanel("PanelCharacterBuff");
        UIBuilder.OpenPanel("PanelCharacterLvL");


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