using System;
using System.Collections.Generic;
using UnityEngine;

public class ProfessionInventory {
    #region Fields
    public List<ProfessionCell> listProfessionCells;
    #endregion
    #region Function
    // Constructor
    public ProfessionInventory() {
        ProfessionCell professionCell = new ProfessionCell();
        listProfessionCells = new List<ProfessionCell>();
        // Create Frofession
        Profession Archer = new Profession("Archer"); // Стрельба из Луков
        professionCell = new ProfessionCell();
        professionCell.profession = Archer;
        listProfessionCells.Add(professionCell);
        Profession Warrior = new Profession("Warrior"); // Воин
        professionCell = new ProfessionCell();
        professionCell.profession = Warrior;
        listProfessionCells.Add(professionCell);
        Profession Mage = new Profession("Mage"); // Маг
        professionCell = new ProfessionCell();
        professionCell.profession = Mage;
        listProfessionCells.Add(professionCell);
        Profession Blacksmith = new Profession("Blacksmith"); // Кузнец
        professionCell = new ProfessionCell();
        professionCell.profession = Blacksmith;
        listProfessionCells.Add(professionCell);
        Profession Carpenter = new Profession("Carpenter"); // Плотник
        professionCell = new ProfessionCell();
        professionCell.profession = Carpenter;
        listProfessionCells.Add(professionCell);
        Profession Tailor = new Profession("Tailor"); // Портной
        professionCell = new ProfessionCell();
        professionCell.profession = Tailor;
        listProfessionCells.Add(professionCell);
        Profession Tradesman = new Profession("Tradesman"); // Купец
        professionCell = new ProfessionCell();
        professionCell.profession = Tradesman;
        listProfessionCells.Add(professionCell);
        Profession Fisherman = new Profession("Fisherman"); // Рыбак
        professionCell = new ProfessionCell();
        professionCell.profession = Fisherman;
        listProfessionCells.Add(professionCell);
        Profession Miner = new Profession("Miner"); // Рудокоп
        professionCell = new ProfessionCell();
        professionCell.profession = Miner;
        listProfessionCells.Add(professionCell);
        Profession Trainer = new Profession("Trainer"); // Дресировщик
        professionCell = new ProfessionCell();
        professionCell.profession = Trainer;
        listProfessionCells.Add(professionCell);
        Profession Herbalism = new Profession("Herbalism"); // Травничество
        professionCell = new ProfessionCell();
        professionCell.profession = Herbalism;
        listProfessionCells.Add(professionCell);
        Profession Freatment = new Profession("Freatment"); // Лечение
        professionCell = new ProfessionCell();
        professionCell.profession = Freatment;
        listProfessionCells.Add(professionCell);
        Profession Alchemy = new Profession("Alchemy"); // Алхимия
        professionCell = new ProfessionCell();
        professionCell.profession = Alchemy;
        listProfessionCells.Add(professionCell);
        Profession Cooking = new Profession("Cooking"); // Кулинария
        professionCell = new ProfessionCell();
        professionCell.profession = Cooking;
        listProfessionCells.Add(professionCell);
        Profession Farming = new Profession("Farming"); // Фермерство
        professionCell = new ProfessionCell();
        professionCell.profession = Farming;
        listProfessionCells.Add(professionCell);
        Profession Jewelry = new Profession("Jewelry"); // Ювелир
        professionCell = new ProfessionCell();
        professionCell.profession = Jewelry;
        listProfessionCells.Add(professionCell);
        Profession Architecture = new Profession("Architecture"); // Архитектор
        professionCell = new ProfessionCell();
        professionCell.profession = Architecture;
        listProfessionCells.Add(professionCell);
        Profession Military = new Profession("Military"); // Военный Архитектор
        professionCell = new ProfessionCell();
        professionCell.profession = Military;
        listProfessionCells.Add(professionCell);
        Profession Bricklayer = new Profession("Bricklayer"); // Каменщик
        professionCell = new ProfessionCell();
        professionCell.profession = Bricklayer;
        listProfessionCells.Add(professionCell);
        Profession Lumberjack = new Profession("Lumberjack"); // Лесоруб
        professionCell = new ProfessionCell();
        professionCell.profession = Lumberjack;
        listProfessionCells.Add(professionCell);
        Profession Butcher = new Profession("Butcher"); // Мясник
        professionCell = new ProfessionCell();
        professionCell.profession = Butcher;
        listProfessionCells.Add(professionCell);
        Profession Thief = new Profession("Thief"); // Вор
        professionCell = new ProfessionCell();
        professionCell.profession = Thief;
        listProfessionCells.Add(professionCell);
    }
    // Public
    public List<ProfessionCell> GetAllProfessionCell() => listProfessionCells;
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