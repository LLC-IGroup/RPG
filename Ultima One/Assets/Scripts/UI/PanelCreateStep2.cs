using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelCreateStep2 : BasePanel {
    #region Fields
    // Public
    [SerializeField] public GameObject panelHistoryCellPrefab;
    [SerializeField] public GameObject panelContent;
    [HideInInspector] public string selectHistoryName;
    [HideInInspector] public List<GameObject> listPanelHistoryCell;
    // Female Historys
    [HideInInspector] private List<CharacterHistory> femaleHistory = new List<CharacterHistory>();
    [HideInInspector] private List<CharacterHistory> maleHistory = new List<CharacterHistory>();
    // Private 
    [HideInInspector] private bool select;
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
        select = false;
        panelName = "PanelCreateStep2";
        SetDrag(false);
        listPanelHistoryCell = new List<GameObject>();
    }
    override public void Start() {
        base.Start();
        listPanelHistoryCell.Clear();
        // Male
        CharacterHistory characterHistory = null;
        characterHistory = new CharacterHistory();
        characterHistory.historyName = "M1";
        characterHistory.history = "";
        maleHistory.Add(characterHistory);
        characterHistory = new CharacterHistory();
        characterHistory.historyName = "M2";
        characterHistory.history = "";
        maleHistory.Add(characterHistory);
        characterHistory = new CharacterHistory();
        characterHistory.historyName = "M3";
        characterHistory.history = "";
        maleHistory.Add(characterHistory);
        characterHistory = new CharacterHistory();
        characterHistory.historyName = "M4";
        characterHistory.history = "";
        maleHistory.Add(characterHistory);
        // Female
        characterHistory = new CharacterHistory();
        characterHistory.historyName = "F1";
        characterHistory.history = "Она любила простую одежду: туфли, свитера,юбка из толстой ткани, кожаный пояс. Узкое лицо, большие глаза. Не красивая в обыкновенном понимании,но имеющая незаурядность,которая более притягательна,чем красота.Пылкая Тери.Она могла повести за собой армию, если бы нашла то,во что поверила бы безоговорочно.Рано ушла из дома.Так она решила.Но тоска по родным шла за ней долго, правда потомотпустила, но и сейчас иногда зимним вечеромтоска подкрадывалась незаметно и сжимала горло добездыханности. Как там родные? Нет ответа.Она так и засыпала с тоской, нопросыпаясь она вновь была готова идти вперед.Так она решила.";
        femaleHistory.Add(characterHistory);
        characterHistory = new CharacterHistory();
        characterHistory.historyName = "F2";
        characterHistory.history = "Ты скорее всего пройдешь мимо,почти незаметив ее. Но считай себя неудачником, если такое произойдет. Светлая, тонкая, открытая.Это и внешность и характер. Если ты удачлив и силен, она рядом и тихо охраняет твое счастье. У тебя куча неприятностей и ты всеми забыт? Она рядом и ты тихо и незаметно вновь поднимаешься, становясь еще более сильным.В этом ее суть.Она начала осозновать себя очень рано.Самые первые воспоминания: лошади, повозка, снег. Потом четко и много: серебряный жук, стрекозы, поля, белые дома, ласковая рука бабушки. Следом почти резко : белые дома в дыму, бегущие люди, задыхающиеся от гари и напряжения.Не родная чужеземная речь и горе, много горя вокруг. ";
        femaleHistory.Add(characterHistory);
        characterHistory = new CharacterHistory();
        characterHistory.historyName = "F3";
        characterHistory.history = "Увидел и не смог забыть?!Это про нее. Проходи-проходи мимо, шею только не сверни исто раз подумай,прежде чем подойти.Но если подошел,знай,нет более сердечного и преданногодруга, не будет у тебя более необузданной страсти, которуюона подарит. Но и ты должен быть таким же.Один раз ее предашь, второгораза для тебя не будет. Дерзай и возможно ты не пожалеешь.Откуда у нее на шее этот золотой самородок на цепочке,необработанный золотой самородок , как и она сама?Он с ней с самомго раннего детства.? Она чувствовала, чтоон что-то значит и берегла его больше всего на свете. Только один раз она увидела, как чужестранец с изумлением увидев это украшение у нее на шее, замер и почтительно отступил, склонив голову. Она рванулась к нему, что вы знаете, трясла она его за руку, знаете, откудая? Лучше быть живой, чем узнать правду, ответил он...";
        femaleHistory.Add(characterHistory);
        characterHistory = new CharacterHistory();
        characterHistory.historyName = "F4";
        characterHistory.history = "Медлительность и плавность в движениях. Округлость и мягкость линий и голоса. Гибкость в теле и суждениях. Она обволакивает взглядом и голосом. Слушать ее, это все равно, что слушать Бетховена. Он захватит ваше внимание и полностью подчинит себе. На время вы потеряете силу, смелость и быстроту реакции, но с последним словом, как и с последней нотой, вы ощутите небывалую легкость, освобождение и силу, которой  так не хватало вам.Доверьтесь ей и вы снова будете готовы к свершениям. Ее принесли к пожилой женщине, жившей на окраине села совсем младенцем, она была завернута в очень дорогие ткани. Отсыпали монеты чистым золотом и сказали, воспитай, пройдет время и мы придем за ней, научи ее всему, что знаешь сама.";
        femaleHistory.Add(characterHistory);
        // Remove All Childrens
        RemoveAllChildren(panelContent);
        int historyCount;
        GameObject panelHistoryCell;
        switch (NewCharacterController.createParams.sex) {
            case PrivateParam.CharacterSex.MALE:
            historyCount = 4;
            for (int i = 0; i < historyCount; i++) {
                panelHistoryCell = Instantiate<GameObject>(panelHistoryCellPrefab, panelContent.transform);
                panelHistoryCell.GetComponent<PanelHistoryCell>().SetParam(maleHistory[i].historyName, maleHistory[i].history);
                listPanelHistoryCell.Add(panelHistoryCell);
            }
            break;
            case PrivateParam.CharacterSex.FEMALE:
            historyCount = 4;
            for (int i = 0; i < historyCount; i++) {
                panelHistoryCell = Instantiate<GameObject>(panelHistoryCellPrefab, panelContent.transform);
                panelHistoryCell.GetComponent<PanelHistoryCell>().SetParam(femaleHistory[i].historyName, femaleHistory[i].history);
                listPanelHistoryCell.Add(panelHistoryCell);
            }
            break;
        }
        PanelHistoryCell.Select += this.SelectCell;
    }
    #endregion
    #region Function
    // Public
    public bool IsPanelValid() => select;
    public void UnSellectAllCell() {
        foreach (GameObject panelHistory in listPanelHistoryCell)
            if (panelHistory != null)
                panelHistory.GetComponent<PanelHistoryCell>().UnSelect();
    }
    public void SelectableCell(string historyName) {
        foreach (GameObject panelHistory in listPanelHistoryCell)
            if (panelHistory != null &&
                panelHistory.GetComponent<PanelHistoryCell>().historyName == historyName)
                panelHistory.GetComponent<PanelHistoryCell>().SelectCell();
    }
    // Private
    private void SelectCell(string historyName) {
        select = true;
        selectHistoryName = historyName;
        UnSellectAllCell();
        SelectableCell(historyName);
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