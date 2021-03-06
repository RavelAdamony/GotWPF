﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace DataAccessLayer
{
    public interface IDal
    {
        List<House> GetAllHouses();
        House GetHouseById(int id);
        void SaveHouse(House house);
        void UpdateHouse(House house);
        void DeleteHouse(House house);
       

        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        void SaveCharacter(Character character);
        void UpdateCharacter(Character character);
        void DeleteCharacter(Character character);


        List<Fight> GetAllFights();
        Fight GetFightById(int id);
        List<Fight> GetFightsByIdHouse(int id);
        void SaveFight(Fight fight);
        void UpdateFight(Fight fight);
        void DeleteFight(Fight fight);


        List<Territory> GetAllTerritories();
        Territory GetTerritoryById(int id);
        void SaveTerritory(Territory territory);
        void UpdateTerritory(Territory territory);
        void DeleteTerritory(Territory territory);


        List<TerritoryType> GetAllTerritoryTypes();
        TerritoryType GetTerritoryTypeById(int id);
        void SaveTerritoryType(TerritoryType territoryType);


        List<CharacterType> GetAllCharacterTypes();
        CharacterType GetCharacterTypeById(int id);
        void SaveCharacterType(CharacterType characterType);


        List<RelationType> GetAllRelationTypes();
        RelationType GetRelationTypeById(int id);
        void SaveRelationType(RelationType relationType);


        List<War> GetAllWars();
        War GetWarById(int id);
        void SaveWar();

        int GetLastId(String table);
        

    }
}
