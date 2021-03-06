﻿using RPG.Weapons;

namespace RPG.Characters
{
    using RPG.Weapons;

    public class WarriorWithAxe : Warrior
    {
        public Axe Weapon { get; set; }

        public override string ToString()
        {
            return string.Format("{0} wields weapon {1}",
                "Warrior", "Axe");
        }
    }
}
