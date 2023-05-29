using System;
using System.Collections.Generic;
using RoleplayGame.Encounters;
using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Scenarios;

namespace Program
{

    public class TestScenary : IScenario
    {
        private List<Character> characters = new List<Character>();

        public void Setup()
        {
            Minotaur minotaur = new Minotaur("Minotaur");
            Witch witch = new Witch("Witch");
            Pirate pirate = new Pirate("Pirate");
            Troll troll = new Troll("Troll");
            Wizard wizard = new Wizard("Wizard");
            Elf elf = new Elf("Elf");

            characters.Add(witch);
            characters.Add(pirate);
            characters.Add(minotaur);
            characters.Add(troll);
            characters.Add(wizard);
            characters.Add(elf);

            foreach (Character character in characters)
            {
                character.AddItem(ItemFactory.GetRandomItem(character.Items));
                character.AddItem(ItemFactory.GetRandomItem(character.Items));
            }
        }

        public void Run()
        {
            AttackEncounter encounterOne = EncounterFactory.GetEncounter(EncounterType.Attack, characters[0], characters[1]) as AttackEncounter;
            encounterOne.Reporter = new ConsoleReporter();
            encounterOne.DoEncounter();
            Character EnconunterOneWinner = encounterOne.DecideWinner();
            EnconunterOneWinner.HealthItself();

            AttackEncounter encounterTwo = EncounterFactory.GetEncounter(EncounterType.Attack,  EnconunterOneWinner, characters[2]) as AttackEncounter;
            encounterTwo.Reporter = new ConsoleReporter();
            encounterTwo.DoEncounter();
            Character EnconunterTwoWinner = encounterTwo.DecideWinner();
            EnconunterOneWinner.HealthItself();

            Console.WriteLine("The winner is: " + EnconunterTwoWinner.Name);
        }
    }
}