using UnityEngine;
using UnityEngine.UI;

public class PanelCharacterAvatar : BasePanel {
    #region Fields
    [SerializeField] public Image imageAvatar;
    [SerializeField] public Text textCharcterName;
    [SerializeField] public Text textLvl;
    [SerializeField] public Text textCurrentHP;
    [SerializeField] public Text textMaxHP;
    [SerializeField] public Text textCurrentMP;
    [SerializeField] public Text textMaxMP;
    [SerializeField] public Text textCurrentEnergy;
    [SerializeField] public Text textMaxEnergy;
    [SerializeField] public Text textCurrentHunger;
    [SerializeField] public Text textMaxHunger;
    [SerializeField] public Slider sliderHP;
    [SerializeField] public Slider sliderMP;
    [SerializeField] public Slider sliderEnergy;
    [SerializeField] public Slider sliderHunger;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        base.OnValidate();

    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        base.Awake();
        // Set Params
        panelName = "PanelCharacterAvatar";
        SetDrag(false);
    }
    override public void Start() {
        base.Start();
        UpdatePanel();

    }
    void Update() {
        UpdatePanel();

    }
    #endregion
    #region Function
    // Public
    override public void UpdatePanel() {
        base.UpdatePanel();
        // HP
        sliderHP.value = (CharacterParam.param.HP * (CharacterParam.privateParams.maxHP / 100)) / 100;
        textCurrentHP.text = CharacterParam.param.HP.ToString();
        textMaxHP.text = CharacterParam.privateParams.maxHP.ToString();
        // MP
        sliderMP.value = (CharacterParam.param.MP * (CharacterParam.privateParams.maxMP / 100)) / 100;
        textCurrentMP.text = CharacterParam.param.MP.ToString();
        textMaxMP.text = CharacterParam.privateParams.maxMP.ToString();
        // Energy
        sliderEnergy.value = (CharacterParam.param.energy * (CharacterParam.privateParams.maxEnergy / 100)) / 100;
        textCurrentEnergy.text = CharacterParam.param.energy.ToString();
        textMaxEnergy.text = CharacterParam.privateParams.maxEnergy.ToString();
        // Hunger
        sliderHunger.value = (CharacterParam.param.hunger * (CharacterParam.privateParams.maxHunger / 100)) / 100;
        textCurrentHunger.text = CharacterParam.param.hunger.ToString();
        textMaxHunger.text = CharacterParam.privateParams.maxHunger.ToString();

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