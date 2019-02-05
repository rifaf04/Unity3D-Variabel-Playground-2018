using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {
	void Start () {
		TellMeAStoryDoneRight();
	}

	void DemoOperators() {
		bool trueValue = true;
		bool falseValue = false;
		int myInt = 35;
		string myString = "This whole ZomBear situation is getting" +
		                  "out of hand.";
		
		print("trueValue == true: " + (trueValue == true));
		print("trueValue == false: " + (trueValue == false));
		print("falseValue == true: " + (falseValue == true));
		print("falseValue == false: " + (falseValue != false));
		print("myInt == 35: " + (myInt == 35));
		print("myString == Ben's a hero!: " + (myString == "Ben's a hero!"));
		print("myString.Equals(Ben's a hero!): " +
		      myString.Equals("Ben's a hero!"));

		print("myInt > 50: " + (myInt > 50));
		print("myInt < 50: " + (myInt < 50));
		print("myInt >= 35: " + (myInt >= 35));
		print("myInt <= 35: " + (myInt <= 35));

		print("true && false: " + (trueValue && falseValue));
		print("true || false: " + (trueValue || falseValue));
		print("myInt > 50 && myInt < 50: " + (myInt > 50 && myInt < 50));
		print("myInt > 50 || myInt < 50: " + (myInt > 50 || myInt < 50));
	}

	void PrecisionCheck() {
		double myDouble = 0.1000000000000001d;
		float myFloat = 0.0000001f;
		int myInt = 1;

		myDouble += myInt;
		myFloat += myInt;

		float myDoubleAsFloat = (float) myDouble;
		myFloat += (float) myDouble;
		myInt += (int) myDouble;

		print(myDouble);
		print(myFloat);
		print(myInt);

		print(myDoubleAsFloat);
		print((double) myDoubleAsFloat);
	}

	void TellMeAStory() {
		var myChar = 'a';
		var myString = "My First string";
		var myBool = false;

		var levelXp = 10;
		
		var heroName = "Ben the Noob";
		var heroWeapon = "Foam Sword";
		var heroBattleCry = "don't hurt me.";
		var heroXp = 0;
		var heroAlignmentPercent = 0.05f;
		var heroMovementSpeed = 1.05f;

		print("Hero Name: " + heroName);
		print("Hero Battle Cry: " + heroBattleCry);
		print("Hero Total XP: " + heroXp);
		print("Hero Alignment %: " + heroAlignmentPercent);
		print("Hero Movement Speed: " + heroMovementSpeed);
		print("Hero Level: " + heroXp / levelXp);
		print("Hero Level XP: " + heroXp % levelXp);

		int heroLevel = heroXp / levelXp;

		switch (heroLevel) {
			case 0:
			case 1:
				print("I'm just not strong enough.");
				break;
			case 2:
			case 3:
				print("I'm almost ready.");
				break;
			default:
				print("I'm coming for you, Dr. ZomBear!!");
				break;
		}

		string villainName = "Dr. ZomBear";
		string villainWeapon = "Nun-Chucks, but made out of teddy bears.";
		string villainBattleCry = "My agent said this would be a big role...";
		villainBattleCry += " but this is getting a little weird";
		int villainXp = 0;
		float villainAlignmentPercent = 0.0f;
		float villainMovementSpeed = 1.3f;
		bool villainIsEvil = false;
		
		print("Villain Name: " + villainName);
		print("Villain Battle Cry: " + villainBattleCry);
		print("Villain Total XP: " + villainXp);
		print("Villain Alignment %: " + villainAlignmentPercent);
		print("Villain Movement Speed: " + villainMovementSpeed);
		print("Villain Level: " + villainXp / levelXp);
		print("Villain Level XP: " + villainXp % levelXp);
		print("Villain is Evil: " + villainIsEvil);

		heroName = heroName.Replace("Noob",
			"Minor Character from a One-Season Indie Film");
		heroWeapon = heroWeapon.Remove(0, 5);
		heroBattleCry = heroBattleCry.ToUpper();
		heroXp += 35;
		heroXp++;
		heroMovementSpeed -= 0.2f;
		heroAlignmentPercent *= 2;

		print("Hero Name: " + heroName);
		print("Hero Battle Cry: " + heroBattleCry);
		print("Hero Total XP: " + heroXp);
		print("Hero Alignment %: " + heroAlignmentPercent);
		print("Hero Movement Speed: " + heroMovementSpeed);
		print("Hero Level: " + heroXp / levelXp);
		print("Hero Level XP: " + heroXp % levelXp);
		
		heroLevel = heroXp / levelXp;

		switch (heroLevel) {
			case 0:
			case 1:
				print("I'm just not strong enough.");
				break;
			case 2:
			case 3:
				print("I'm almost ready.");
				break;
			default:
				print("I'm coming for you, Dr. ZomBear!!");
				break;
		}

		villainWeapon = villainWeapon.Substring(0, 10);
		villainBattleCry = villainBattleCry.Insert(3, "lying ")
			.Replace("but", "and");
		villainXp += 18;
		villainMovementSpeed += 0.1f;
		villainAlignmentPercent *= 1.5f;

		print("Villain Name: " + villainName);
		print("Villain Battle Cry: " + villainBattleCry);
		print("Villain Total XP: " + villainXp);
		print("Villain Alignment %: " + villainAlignmentPercent);
		print("Villain Movement Speed: " + villainMovementSpeed);
		print("Villain Level: " + villainXp / levelXp);
		print("Villain Level XP: " + villainXp % levelXp);
		print("Villain is Evil: " + villainIsEvil);
		print(villainIsEvil ? "What are you on?" : "This check better clear.");

		villainIsEvil = !villainIsEvil;
		print("Is he really, though? " + villainIsEvil);
		print(villainIsEvil ? "What are you on?" : "This check better clear.");
	}

	void TellMeAStoryDoneRight() {
		var levelXp = 10;
		
		var heroName = "Ben the Noob";
		var heroWeapon = "Foam Sword";
		var heroBattleCry = "don't hurt me.";
		var heroXp = 0;
		var heroAlignmentPercent = 0.05f;
		var heroMovementSpeed = 1.05f;
		
		var hero = new Character("Ben the Noob", "Foam Sword", "don't hurt me.", 0, 0.05f, 1.05f, true, 10);

		hero.PrintInfo();
		
		print(GetStatus(calculateLevel(heroXp, levelXp)));
		
		var villain = new Villain("Dr. ZomBear", "Nun-Chucks, but made out of teddy bears.",
			"My agent said this would be a big role... but this is getting a little weird",
			0, 0.0f, 1.3f, false, 10, false);
		
		villain.PrintInfo();
	}

	void PrintInfo(bool isHero, string name, string weapon, string battleCry, int levelXp,
		int xp, float alignmentPercent, float movementSpeed) {
		string character = isHero ? "Hero" : "Villain";

		print(GetPrintStatement(character, "Name", name));
		print(GetPrintStatement(character, "Weapon", weapon));
		print(GetPrintStatement(character, "Battle Cry", battleCry));
		print(GetPrintStatement(character, "Total XP", xp.ToString()));
		print(GetPrintStatement(character, "Alignment %", alignmentPercent.ToString()));
		print(GetPrintStatement(character, "Movement Speed", movementSpeed.ToString()));
		print(GetPrintStatement(character, "Level", calculateLevel(xp, levelXp).ToString()));
		print(GetPrintStatement(character, "Level XP", calculateLevelXp(xp, levelXp).ToString()));
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
