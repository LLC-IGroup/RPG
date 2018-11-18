using System;
using System.Xml;
using UnityEngine;

public class SkillBuilder {
    #region Fields
    // Private
    static private XmlDocument XMLDoc = new XmlDocument();
    static private XmlElement XMLRoot;
    #endregion
    #region Function
    // Public
    static public BaseSkill GetSkillByName(string skillName) {
        if (XMLRoot == null) {
            XMLDoc.Load("Assets/XML/Skills.xml");
            XMLRoot = XMLDoc.DocumentElement;
        }
        // Get All Skills
        XmlNodeList rootNodes = XMLRoot.GetElementsByTagName("Skill");
        foreach (XmlNode skillNode in rootNodes) {
            XmlNodeList skillNodes = skillNode.ChildNodes;
            foreach (XmlNode node in skillNodes) {
                // Get Item By Name
                if (node.Name.Equals("Name") &&
                    node.InnerText.Equals(skillName)) {
                    return GetSkill(skillNode);
                }
            }
        }
        return null;
    }
    // Private
    private static BaseSkill GetSkill(XmlNode skillNode) {
        XmlAttribute xmlAttribute = skillNode.Attributes[0];
        BaseSkill.SkillType type = GetSkillType(xmlAttribute.InnerText);
        switch (type) {
            case BaseSkill.SkillType.ACTIVE:
            return CreateActiveSkill(skillNode);
            case BaseSkill.SkillType.PASIVE:
            return CreatePassiveSkill(skillNode);
            case BaseSkill.SkillType.EMOTION:
            return CreateEmotionSkill(skillNode);
        }
        return null;
    }
    private static BaseSkill.SkillType GetSkillType(string innerText) {
        switch (innerText) {
           case "ACTIVE":
            return BaseSkill.SkillType.ACTIVE;
            case "PASIVE":
            return BaseSkill.SkillType.PASIVE;
            case "EMOTION":
            return BaseSkill.SkillType.EMOTION;
        }
        return BaseSkill.SkillType.ERROR;
    }
    private static EmotionSkill CreateEmotionSkill(XmlNode skillNode) {
        EmotionSkill emotionSkill = new EmotionSkill();
        emotionSkill.SetBase(GetBaseSkill(skillNode));
        emotionSkill.skillType = BaseSkill.SkillType.EMOTION;
        return emotionSkill;
    }
    private static PasiveSkill CreatePassiveSkill(XmlNode skillNode) {
        PasiveSkill pasiveSkill = new PasiveSkill();
        pasiveSkill.SetBase(GetBaseSkill(skillNode));
        pasiveSkill.skillType = BaseSkill.SkillType.PASIVE;
        return pasiveSkill;

    }
    private static ActiveSkill CreateActiveSkill(XmlNode skillNode) {
        ActiveSkill activeSkill = new ActiveSkill();
        activeSkill.SetBase(GetBaseSkill(skillNode));
        activeSkill.skillType = BaseSkill.SkillType.ACTIVE;
        return activeSkill;

    }
    private static BaseSkill GetBaseSkill(XmlNode skillNode) {
        BaseSkill baseSkill = new BaseSkill();
        foreach (XmlNode node in skillNode.ChildNodes) {
            switch (node.Name) {
                case "Name":
                baseSkill.name = node.InnerText;
                break;
                case "GameName":
                baseSkill.gameName = node.InnerText;
                break;
                case "Description":
                baseSkill.description = node.InnerText;
                break;
                case "IconName":
                baseSkill.iconName = node.InnerText;
                break;
                case "CastTime":
                float.TryParse(node.InnerText, out baseSkill.castTime);
                break;
                case "CoolDown":
                float.TryParse(node.InnerText, out baseSkill.coolDown);
                break;
                case "PrafabName":
                baseSkill.prefabName = node.InnerText;
                break;
            }
        }
        return baseSkill;
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