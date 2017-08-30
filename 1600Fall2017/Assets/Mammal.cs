using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal {

   public override void Start() {
        base.Start();
        Livebirth();
}


   void Livebirth () {
        print(this.name + " Live Births");
    }
}
