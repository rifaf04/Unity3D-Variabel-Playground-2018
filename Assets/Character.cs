using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character {
   public string name;
   public string weapon;
   public string battleCry;
   public int xp;
   public float alignmentPercent;
   public float movementSpeed;
   public bool isHero;
   public int levelXp;

   protected Character() {
      
   }

   public Character(string name, string weapon, string battleCry, int xp, float alignmentPercent,
      float movementSpeed, bool isHero, int levelXp) {
      this.name = name;
      this.weapon = weapon;
      this.battleCry = battleCry;
      this.xp = xp;
      this.levelXp = levelXp;
      this.alignmentPercent = alignmentPercent;
      this.movementSpeed = movementSpeed;
      this.isHero = isHero;
      this.levelXp = levelXp;
   }
   
   public void PrintInfo() {
      string character = isHero ? "Hero" : "Villain";

      Debug.Log(GetPrintStatement(character, "Name", name));
      Debug.Log(GetPrintStatement(character, "Weapon", weapon));
      Debug.Log(GetPrintStatement(character, "Battle Cry", battleCry));
      Debug.Log(GetPrintStatement(character, "Total XP", xp.ToString()));
      Debug.Log(GetPrintStatement(character, "Alignment %", alignmentPercent.ToString()));
      Debug.Log(GetPrintStatement(character, "Movement Speed", movementSpeed.ToString()));
      Debug.Log(GetPrintStatement(character, "Level", calculateLevel(xp, levelXp).ToString()));
      Debug.Log(GetPrintStatement(character, "Level XP", calculateLevelXp(xp, levelXp).ToString()));
   }

   string GetPrintStatement(string character, string field, string value) {
      return string.Format("{0} {1}: {2}", character, field, value);
   }

   int calculateLevel(int xp, int levelXp) {
      return xp / levelXp;
   }

   int calculateLevelXp(int xp, int levelXp) {
      return xp % levelXp;
   }

   string GetStatus(int level) {
      switch (level) {
         case 0:
         case 1:
            return "I'm just not strong enough.";
         case 2:
         case 3:
            return "I'm almost ready.";
         default:
            return "I'm coming for you, Dr. ZomBear!!";
      }
   }
}
