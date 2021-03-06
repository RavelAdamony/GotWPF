﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;
using WebApiGoT.Models;

namespace WebApiGoT.Controllers
{
    [RoutePrefix("api/territory")]
    public class TerritoryController : ApiController
    {
        ThronesTournamentManager businessManager = new ThronesTournamentManager();

        [Route("GetAllTerritories")]
        public List<TerritoryDTO> GetAllTerritories()
        {
            List<TerritoryDTO> listTerritory = new List<TerritoryDTO>();

            foreach (var territory in businessManager.ListTerritories())
            {
                listTerritory.Add(new TerritoryDTO() {
                    Owner = territory.Owner.FirstName + " " + territory.Owner.LastName,
                    TerritoryType = territory.TerritoryType.ToString()
            });
            }

            return listTerritory;
        }

        [Route("GetTerritoryById/{id:int}")]
        public TerritoryDTO GetTerritoryById(int id)
        {
            var territory = businessManager.GetTerritory(id);

            TerritoryDTO territoryDTO = new TerritoryDTO() {
                Owner = territory.Owner.FirstName + " " + territory.Owner.LastName,
                TerritoryType = territory.TerritoryType.ToString()
            };

            return territoryDTO;
        }

        [Route("SaveTerritory/{territoryType_id}/{owner_id}")]
        [HttpPost]
        public void SaveTerritory(int territoryType_id, int owner_id)
        {
            businessManager.AddTerritory(territoryType_id, owner_id);

        }

        [Route("UpdateTerritory/{idTerritory}/{territoryType_id}/{owner_id}")]
        [HttpPut]
        public void UpdateTerritory(int idTerritory, int territoryType_id, int owner_id)
        {
            businessManager.UpdateTerritory(idTerritory, territoryType_id, owner_id);

        }

        [Route("DeleteTerritory/{idTerritory}")]
        [HttpDelete]
        public void DeleteCharacter(int idTerritory)
        {
            businessManager.DeleteTerritory(idTerritory);

        }
    }
}
