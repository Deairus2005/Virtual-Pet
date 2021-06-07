using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
	public class RoboPet
	{
        public readonly bool IsRobotic=true;


        private string Name{get;set;}
        public void SetName(string name){Name = name;}
        public string GetName(){return Name;}

        
        private string Species { get; set; }
        public void SetSpecies(string species){ Species = species;}
        public string GetSpecies(){return Species;}


		public int OilLevel=50;
        public void SetOilLevel(int Level){OilLevel=Level;}
        public int GetOilLevel(){return OilLevel;}


        public int BatteryLevel=25;
        public void SetBatteryLevel(int Level){BatteryLevel=Level;}
        public int GetBatteryLevel(){return BatteryLevel;}


        public int HeatLevel=10;
        public void SetHeatLevel(int Level){HeatLevel=Level;}
        public int GetHeatLevel(){return HeatLevel;}



	}
}
