﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager {
    public class Pet {
        public string Name { get; set; }
        public string Breed { get; set; }
    }

    // add hashcode
    public override int GetHashCode()
    {
        
    }

    public override bool Equals(object obj) {
        if (!(obj is Pet)) {
            return object.Equals(obj, this);
        }
        var pet = (Pet)obj;
        return Birthday.Equals(pet.Birthday) && string.Equals(this.Name, pet.Name) &&
        string.Equals(this.Breed, pet.Breed);
    }

    public override bool Equals(object obj)
    {
        if (!(obj is Pet))
        {
        return object.Equals(obj, this);
        }
        var pet = (Pet)obj;
        return Birthday.Equals(pet.Birthday) && string.Equals(this.Name, pet.Name) &&
        string.Equals(this.Breed, pet.Breed);
    }
}
