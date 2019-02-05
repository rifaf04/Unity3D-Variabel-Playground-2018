using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villain : Character {
   public bool isEvil;
   
   public Villain(string name, string weapon, string battleCry, int xp, float alignmentPercent,
      float movementSpeed, bool isHero, int levelXp, bool isEvil) {
      this.name = name;
      this.weapon = weapon;
      this.battleCry = battleCry;
      this.xp = xp;
      this.levelXp = levelXp;
      this.alignmentPercent = alignmentPercent;
      this.movementSpeed = movementSpeed;
      this.isHero = isHero;
      this.levelXp = levelXp;
      this.isEvil = isEvil;
   }
}
