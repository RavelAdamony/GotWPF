using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApiGoT.Models
{
    public class HouseDTO
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int NumberOfUnities { get; set; }
        public List<CharacterDTO> Housers;


        public HouseDTO() {

            this.Name = "Inconnu";
            this.NumberOfUnities = 0;

            this.Housers = new List<CharacterDTO>();
        }
    }
}