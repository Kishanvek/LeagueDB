using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LeagueDB.Models;

namespace LeagueDB.DAL
{
    public class LeagueInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LeagueDBContext>
    {
        protected override void Seed(LeagueDBContext context)
        {
            var champions = new List<Champion>
            {
            new Champion{ID="Garen",Q="Decisive Strike: Garen gains a burst of movement speed, breaking free of all slows affecting him. His next attack strikes a vital area of his foe, dealing bonus damage and silencing them. Garen breaks free from all slows affecting him, and gains 30% movement speed for 1.5 / 2 / 2.5 / 3 / 3.5 seconds.His next basic attack within 4.5 seconds deals 30 / 55 / 80 / 105 / 130(+140 % Attack Damage) physical damage and silences his target for 1.5 seconds.",
                W ="Courage: Garen passively increases his armor and magic resist by killing enemies. He may also activate this ability to grant himself a shield that reduces incoming damage for a short time. Passive: Killing units permanently grants 0 armor and magic resist, up to a maximum of 30. Current Bonus: 0Active: Garen gains a defensive shield for 2 / 3 / 4 / 5 / 6 seconds, reducing incoming damage by 30 %.",
                E ="Judgment: Garen performs a dance of death with his sword, dealing damage around him for the duration and shredding the armor of enemy champions hit. Garen rapidly spins his sword around his body for 3 seconds, dealing 0 physical damage to nearby enemies-- 14 / 18 / 22 / 26 / 30 plus 34 / 35 / 36 / 37 / 38 % of his attack damage, 0 times(increased by 1 every 3 champion levels)-- over the duration.Enemy champions hit by 4 spins lose 25 % of their armor for 6 seconds.",
                R ="Demacian Justice: The enemy champion with the most recent kills is the Villain. Garen's attacks deal additional true damage to that champion. Garen can call upon the might of Demacia to deal a finishing blow to an enemy champion that deals damage based upon how much health his target has missing. This damage is true damage against the Villain.",
                Passive ="Perseverance: If Garen has not recently been struck by damage or enemy abilities, he regenerates a percentage of his maximum health each second. Minion damage does not stop Perseverance."},
            new Champion{ID="Master Yi",
                Q ="Alpha Strike: Master Yi teleports across the battlefield with blinding speed, dealing physical damage to multiple units in his path, while simultaneously becoming untargetable. Alpha Strike can critically strike and deals bonus physical damage to minions and monsters. Basic attacks reduce Alpha Strike's cooldown.",
                W ="Meditate: Master Yi rejuvenates his body by focus of mind, restoring Health and taking reduced damage for a short time.",
                E ="Wuju Style: Master Yi becomes skilled in the art of Wuju, passively increasing his Attack Damage. Activating Wuju Style grants bonus true damage on basic attacks, but the passive bonus is then lost while on cooldown.",
                R ="Highlander: Master Yi moves with unparalleled agility, temporarily increasing his Movement and Attack Speeds as well as making him immune to all slowing effects. While active, Champion kills or assists extend Highlander's duration. Passively reduces cooldown for his other abilities on a kill or assist.",
                Passive ="Double Strike: Every few strikes, Master Yi strikes twice."},
            new Champion{ID="Singed",
                Q ="Poison Trail: Leaves a trail of poison behind Singed, dealing damage to enemies caught in the path.",
                W ="Mega Adhesive: Throws a vial of mega adhesive on the ground, slowing enemies who walk on it.",
                E ="Fling: Damages target enemy unit and flings them into the air behind Singed. If the target Singed flings lands in his Mega Adhesive, they are also rooted.",
                R ="Insanity Potion: Singed drinks a potent brew of chemicals, granting him increased combat stats.",
                Passive ="Empowered Bulwark: Increases Singed's Health by 25 for every 100 Mana he has."},
            };

            champions.ForEach(s => context.Champions.Add(s));
            context.SaveChanges();
            var items = new List<Item>
            {
            new Item {ID="Boots of Speed",
                Gold =300,
                Stats ="UNIQUE Passive - Enhanced Movement: +25 Movement Speed",},
            new Item{ID="Thornmail",
                Gold =2350,
                Stats ="+100 Armor. UNIQUE Passive: Upon being hit by a basic attack, reflects magic damage back to the attacker equal to 25 % of your bonus Armor plus 15 % of the incoming damage. (Bonus Armor is Armor from items, buffs, runes and masteries.) (Reflect damage is calculated based on damage taken before being reduced by Armor.)"},
            new Item{ID="Void Staff",
                Gold =2650,
                Stats ="+80 Ability Power. UNIQUE Passive: +35% Magic Penetration."},
            new Item{ID="Blasting Wand",
                Gold =850,
                Stats ="+40 Ability Power"},
            new Item{ID="Cloth Armor",
                Gold =300,
                Stats ="+15 Armor"},
            new Item{ID="Negatron Cloak",
                Gold =720,
                Stats ="+40 Magic Resist"},
            new Item{ID="Warden's Mail",
                Gold =1000,
                Stats ="+40 Armor. UNIQUE Passive - Cold Steel: When hit by basic attacks, reduces the attacker's Attack Speed by 15% for 1 seconds."}
            };
            items.ForEach(s => context.Items.Add(s));
            context.SaveChanges();
            var builds = new List<Build>
            {
            new Build{ID=1,Item1="Boots of Speed",Item2="Thornmail",Item3="Void Staff",Item4="Blasting Wand",Item5="Cloth Armor",Item6="Negatron Cloak",SumSpell1="Barrier",SumSpell2="Flash"},
            new Build{ID=2,Item1="Negatron Cloak",Item2="Boots of Speed",Item3="Thornmail",Item4="Void Staff",Item5="Blasting Wand",Item6="Cloth Armor",SumSpell1="Clarity",SumSpell2="Flash"},
            new Build{ID=3,Item1="Warden's Mail",Item2="Negatron Cloak",Item3="Boots of Speed",Item4="Thornmail",Item5="Void Staff",Item6="Blasting Wand",SumSpell1="Cleanse",SumSpell2="Flash"},
            new Build{ID=4,Item1="Cloth Armor",Item2="Warden's Mail",Item3="Negatron Cloak",Item4="Boots of Speed",Item5="Thornmail",Item6="Void Staff",SumSpell1="Exhaust",SumSpell2="Flash"},
            new Build{ID=5,Item1="Negatron Cloak",Item2="Cloth Armor",Item3="Warden's Mail",Item4="Negatron Cloak",Item5="Boots of Speed",Item6="Thornmail",SumSpell1="Flash",SumSpell2="Ignite"},
            new Build{ID=6,Item1="Negatron Cloak",Item2="Void Staff",Item3="Cloth Armor",Item4="Warden's Mail",Item5="Negatron Cloak",Item6="Boots of Speed",SumSpell1="Ghost",SumSpell2="Flash"},
            new Build{ID=7,Item1="Negatron Cloak",Item2="Void Staff",Item3="Thornmail",Item4="Cloth Armor",Item5="Warden's Mail",Item6="Negatron Cloak",SumSpell1="Heal",SumSpell2="Flash"},
            new Build{ID=8,Item1="Negatron Cloak",Item2="Void Staff",Item3="Thornmail",Item4="Warden's Mail",Item5="Cloth Armor",Item6="Warden's Mail",SumSpell1="Ignite",SumSpell2="Flash"},
            new Build{ID=9,Item1="Boots of Speed",Item2="Void Staff",Item3="Thornmail",Item4="Warden's Mail",Item5="Cloth Armor",Item6="Cloth Armor",SumSpell1="Smite",SumSpell2="Flash"},
            new Build{ID=10,Item1="Boots of Speed",Item2="Void Staff",Item3="Warden's Mail",Item4="Warden's Mail",Item5="Warden's Mail",Item6="Warden's Mail",SumSpell1="Teleport",SumSpell2="Flash"},
            new Build{ID=11,Item1="Boots of Speed",Item2="Negatron Cloak",Item3="Boots of Speed",Item4="Boots of Speed",Item5="Boots of Speed",Item6="Boots of Speed",SumSpell1="Barrier",SumSpell2="Flash"},
            new Build{ID=12,Item1="Boots of Speed",Item2="Negatron Cloak",Item3="Boots of Speed",Item4="Boots of Speed",Item5="Boots of Speed",Item6="Boots of Speed",SumSpell1="Clarity",SumSpell2="Flash"},
            };
            builds.ForEach(s => context.Builds.Add(s));
            context.SaveChanges();
            var users = new List<User>
            {
                new User {ID="Kishan" },
                new User {ID="Peter" },
                new User {ID="Chuck" },
                new User {ID="Donald" },
                new User {ID="Duck" },
                new User {ID="Mickey" },
                new User {ID="Mouse" },
                new User {ID="Bugs" },
                new User {ID="Bunny" }
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}