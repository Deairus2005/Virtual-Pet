﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet

    {
        private string Name
        {
            get; set;
        }
        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;

        }

        public string Species { get; set; }

        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetSpecies()
        {
            return Species;

        }

    }

}
