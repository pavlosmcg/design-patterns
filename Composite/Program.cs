using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {   
            var maiya = new Meerkat("Maiya");
            var vassily = new Meerkat("Vassily");
            var yakov = new Meerkat("Yakov");
            var bogdan = new Meerkat("Bogdan");

            var sergei = new Meerkat("Sergei");
            var mostBeautiousSisterofSergei = new Meerkat("Beautious Sister Of Sergei");

            //var brotherOfSergeiAlwaysWithTheScratching = new Meerkat("Scratching Brother of Sergei");
            //var wifeOfScratchingBrother = new Meerkat("Wife of Scratching Brother");
            //var scratchyBaby = new Meerkat("Baby of Scratching Brother");
            //var familyMeThinksHasFleas = new Mob{Members = {brotherOfSergeiAlwaysWithTheScratching, wifeOfScratchingBrother, scratchyBaby}};
            
            var sergeiFamily = new Mob {Members = {sergei, mostBeautiousSisterofSergei}}; //add familyMeThinksHasFleas into the extended sergeiFamily Mob
            
            var mothermabobOfBogdan = new Meerkat("Mothermabob of Bogdan");
            var fathermabobOfBogdan = new Meerkat("Fathermabob of Bogdan");
            var bogdanFamily = new Mob {Members = {bogdan, mothermabobOfBogdan, fathermabobOfBogdan}};

            // simplify this to avoid using two Lists?
            var meerkovaVillagers = new List<Meerkat> {maiya, vassily, yakov};
            var meerkovaVillageFamilies = new List<Mob> {sergeiFamily, bogdanFamily};
            
            // simplify this to avoid using any foreach loops
            foreach (var meerkat in meerkovaVillagers)
            {
                meerkat.InviteMyMostStupendousParty();
            }

            foreach (var meerkatFamily in meerkovaVillageFamilies)
            {
               meerkatFamily.InviteEveryoneInFamilyToMyMostStupendousParty();
            }

            Console.ReadLine();
        }
    }
}
