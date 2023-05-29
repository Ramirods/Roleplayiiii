using System;
using System.Collections.Generic;
using RoleplayGame.Encounters;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Scenarios
{

    public class TestScenario : IScenario
    {

        public void Setup()
        {
            Witch witch = new Witch("Witch");
            Pirate pirate = new Pirate("Pirate");
            Minotaur minotaur = new Minotaur("Minotaur");
        }

        public void Run()
        {
            Witch witch = new Witch("Witch");
            Pirate pirate = new Pirate("Pirate");
            Minotaur minotaur = new Minotaur("Minotaur");
        }

    }
}