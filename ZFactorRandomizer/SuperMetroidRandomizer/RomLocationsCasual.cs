//nothing hidden, items are hidden the way they should be
//no limitations
//                                   NoHidden = true,
//                                   ItemStorageType = ItemStorageType.Hidden, {chozo,hidden, blank}

// RULES FOR CASUAL DIFFICULTY
// NO GLITCHES LIKE GGG, ITEMS REVEALED
// WALLJUMP REQUIRED
using System;
using System.Collections.Generic;
using System.Linq;
using SuperMetroidRandomizer.Random;

namespace SuperMetroidRandomizer.Rom
{
    public class RomLocationsCasual : IRomLocations
    {
        public List<Location> Locations { get; set; }
        public string DifficultyName { get { return "Casual"; } }
        public string SeedFileString { get { return "C{0:0000000}"; } }
        public string SeedRomString { get { return "SMRv{0} U{1}"; } }

        public void ResetLocations()
        {
            Locations = new List<Location>
                       {
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Ocean",
                                   Address = 0x7C9E9,
                                   CanAccess =
                                       have =>
                                   	CanEnterWS(have)
                                   	&& CanDefeatPhantoon(have)
									&& have.Contains(ItemType.SpeedBooster)
                                   	&& have.Contains(ItemType.GravitySuit)
                                   	&& have.Contains(ItemType.SpaceJump),
                               },
							
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Grapple Cave",
                                   Address = 0x7C9BF,
                                   CanAccess =
                                       have =>
                                   	have.Contains(ItemType.GrappleBeam)
                                   	
                                   	&& CanLeftSideCrateria(have),
                               },
							
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Elevator Chozo",
                                   Address = 0x7C8E5,
                                   CanAccess =
                                       have =>
                                   	CanEnterPassages(have)
                                   	
                                   	&& CanLeftSideCrateria(have),
                               },
							
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Lake Tank",
                                   Address = 0x7C9AB,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have),
                               },
							
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Pancake House",
                                   Address = 0x7C9F1,
                                   CanAccess =
                                       have =>
                                   	have.Contains(ItemType.SpeedBooster)
                                   	&& CanEnterPassages(have)
                                   	&& have.Contains(ItemType.SuperMissile)
                                   	&& CanLeftSideCrateria(have),
                               },
							
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Red Bluff",
                                   Address = 0x7CB2B,
                                   CanAccess =
                                       have =>
                                   	CanOpenMissileDoors(have)
                                   	&& CanEnterPassages(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							
							
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "ILoveSuperBlocks",
                                   Address = 0x7C943,
                                   CanAccess =
                                       have =>
                                   	CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.Bomb)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							
							
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                    Name = "Old Mother Brain",
                                   Address = 0x7C949,
                                   CanAccess =
                                       have =>
                                   	//softlock if no morph ball
                                   	CanOpenMissileDoors(have),
                               },
							
							
							
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Bomb Torizo",
                                   Address = 0x7C895,
                                   CanAccess =
                                       have =>
                                   	have.Contains(ItemType.MorphingBall)
									&& CanOpenMissileDoors(have),
                               },
							
							
							
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Creep Highway",
                                   Address = 0x7CA1B,
                                   CanAccess =
                                       have =>
                                   	have.Contains(ItemType.SpaceJump),
                                   	//ibj or space jump
                               },
							
							
							
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Cliff Chozo",
                                   Address = 0x7C911,
                                   CanAccess =
                                       have =>
                                   	CanEnterPassages(have)
                                   	 && (have.Contains(ItemType.SpeedBooster)
                                   	
                                   	    || have.Contains(ItemType.SpaceJump)),
                                   	// can add more etanks as a req,
                               },
							
							
							
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Mushroom Etank",
                                   Address = 0x7C98F,
                                   CanAccess =
                                       have =>
                                   	CanEnterPassages(have)
                                   	
									&& (CanUsePowerBombs(have)
                                   	|| CanOpenMissileDoors(have)),
                               },
							
							
							
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Mushroom Cave",
                                   Address = 0x7C995,
                                   CanAccess =
                                       have =>
                                   	CanEnterPassages(have)
                                   	
                                   	&& have.Contains(ItemType.SpeedBooster)
                                   	              
									&& (CanUsePowerBombs(have)
                                   	|| CanOpenMissileDoors(have)),
                               },
							   
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Morphing Ball",
                                   Address = 0x7CBF1,
                                   CanAccess =
                                       have =>
									true,
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Chozo Stash",
                                   Address = 0x7CC11,
                                   CanAccess =
                                       have =>
                                   	have.Contains(ItemType.MorphingBall),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Construction",
                                   Address = 0x7CBEB,
                                   CanAccess =
                                       have =>
                                   	have.Contains(ItemType.MorphingBall),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Cactus Trap",
                                   Address = 0x7CDD1,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have)
                                   	&& have.Contains(ItemType.Bomb)
                                   	&& have.Contains(ItemType.MorphingBall)
                                   	&& (have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.SpaceJump)),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "SporeSpawn Supers",
                                   Address = 0x7CBDD,
                                   CanAccess =
                                       have =>
                                   	(CanEnterEastBrinstar(have) //cannot enter east brinstar w/out bombs
                                   	&& have.Contains(ItemType.GrappleBeam)
                                   	&& have.Count(x => x == ItemType.Missile) >= 5),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "SporeSpawn's Secret",
                                   Address = 0x7CBD7,
                                   CanAccess =
                                       have =>
                                   	(CanEnterEastBrinstar(have) //cannot enter east brinstar w/out bombs
                                   	&& have.Contains(ItemType.GrappleBeam)
									&& have.Contains(ItemType.SpeedBooster)
                                   	&& have.Count(x => x == ItemType.Missile) >= 5),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Dragon Spark",
                                   Address = 0x7CDDF,
                                   CanAccess =
                                       have =>
                                   	CanEnterEastBrinstar(have)
                                   	&& have.Contains(ItemType.SpeedBooster)
                                   	&& have.Contains(ItemType.HiJumpBoots),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Microwaved Egg",
                                   Address = 0x7CC4F,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have)
                                   	&& CanUsePowerBombs(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Sidehopper Secret",
                                   Address = 0x7CC55,
                                   CanAccess =
                                       have =>
									CanEnterEastBrinstar(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Charge Beam",
                                   Address = 0x7CE23,
                                   CanAccess =
                                       have =>
									CanEnterEastBrinstar(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "KiHunter Alley",
                                   Address = 0x7CED5,
                                   CanAccess =
                                       have =>
									CanEnterEastBrinstar(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Crumble Bridge",
                                   Address = 0x7CEAF,
                                   CanAccess =
                                       have =>
									CanEnterEastBrinstar(have)
                                   	&& CanUsePowerBombs(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Treasure Island",
                                   Address = 0x7CF2B,
                                   CanAccess =
                                       have =>
									CanEnterEastBrinstar(have)
                                   	&& have.Contains(ItemType.HiJumpBoots),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Super Secret Saveroom",
                                   Address = 0x7CF33,
                                   CanAccess =
                                       have =>
									CanEnterEastBrinstar(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Clubhouse",
                                   Address = 0x7CC47,
                                   CanAccess =
                                       have =>
                                   	(CanEnterEastBrinstar(have)
                                   	    && have.Contains(ItemType.SuperMissile))
                                   	
									|| (CanEnterEastBrinstar(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.SpeedBooster)),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Brinstar Reserves",
                                   Address = 0x7CF47,
                                   CanAccess =
                                       have =>
									CanEnterEastBrinstar(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Pet Slug",
                                   Address = 0x7CEA7,
                                   CanAccess =
                                       have =>
									CanEnterEastBrinstar(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Flowerhead",
                                   Address = 0x7CE15,
                                   CanAccess =
                                       have =>
                                   	//Boss Skip
									(CanEnterEastBrinstar(have)
                                   	&& have.Contains(ItemType.GravitySuit)
                                   	&& have.Contains(ItemType.SpeedBooster)
                                   	&& have.Contains(ItemType.GrappleBeam))
                                   	
                                   	//Chozo Boss
									|| (CanEnterEastBrinstar(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.ChargeBeam)
 		     						&& have.Count(x => x == ItemType.SuperMissile) >= 4 //count 3
                                   	&& have.Contains(ItemType.GrappleBeam)),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Elevator Cave",
                                   Address = 0x7CE6F,
                                   CanAccess =
                                       have =>
									CanEnterEastBrinstar(have)
                                   	&& CanUsePowerBombs(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Husband",
                                   Address = 0x7CE0D,
                                   CanAccess =
                                       have =>
									CanEnterEastBrinstar(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Wife",
                                   Address = 0x7CE07,
                                   CanAccess =
                                       have =>
									CanEnterEastBrinstar(have)
                                   	&& have.Contains(ItemType.SuperMissile)
                                   	&& CanEnterPassages(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Irrigation",
                                   Address = 0x7CCFF,
                                   CanAccess =
                                       have =>
									CanEnterEastBrinstar(have)
                                   	&& have.Contains(ItemType.GravitySuit)
                                   	&& have.Contains(ItemType.SpeedBooster),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Sunken Warehouse - Grapple",
                                   Address = 0x7CD37,
                                   CanAccess =
                                       have =>
                                   	CanDefeatKraid(have)
                                   	&& CanEnterPassages(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Kraid's House",
                                   Address = 0x7CD3D,
                                   CanAccess =
                                       have =>
                                   	CanAccessTwinStatues(have)
                                   	&& CanEnterPassages(have)
                                   	&& have.Contains(ItemType.SuperMissile), //definition to defeat kraid
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "4 PUNKS",
                                   Address = 0x7CD57, //corrected from 0x7CF57
                                   CanAccess =
                                       have =>
                                   	CanDefeatKraid(have)
                                   	&& have.Contains(ItemType.HiJumpBoots)
                                   	&& (have.Contains(ItemType.GrappleBeam)
                                   	|| have.Contains(ItemType.GravitySuit)
                                   	|| (have.Contains(ItemType.SpaceJump))),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Pirate Cage",
                                   Address = 0x7CC2D,
                                   CanAccess =
                                       have =>
                                   	CanAccessTwinStatues(have)
                                   	&& CanEnterPassages(have)
                                   	&& have.Contains(ItemType.SpeedBooster),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Ripper Hangout",
                                   Address = 0x7CD6B,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Hellraiser",
                                   Address = 0x7CC95,
                                   CanAccess =
                                       have =>
                                   	CanAccessTwinStatues(have)
                                   	&& CanEnterPassages(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Sewer Chozo - Spazer",
                                   Address = 0x7CC8D,
                                   CanAccess =
                                       have =>
                                   	CanAccessTwinStatues(have)
                                   	&& CanEnterPassages(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Varia Suit",
                                   Address = 0x7CBB5,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Red Tower Secret",
                                   Address = 0x7CD9F,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have)
                                   	&& CanUsePowerBombs(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Red Tower Secret Chozo",
                                   Address = 0x7CD9B,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Red Bull - Left",
                                   Address = 0x7CDA9,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have)
                                   	&& have.Contains(ItemType.MorphingBall)
                                   	&& (have.Contains(ItemType.SpeedBooster)
                                   	    || have.Contains(ItemType.SpaceJump)), //+3 etanks, consumes ~50 energy
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Red Bull - Right",
                                   Address = 0x7CDA3,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have)
                                   	&& have.Contains(ItemType.MorphingBall)
                                   	&& (have.Contains(ItemType.SpeedBooster)
                                   	    || have.Contains(ItemType.SpaceJump)), //+3 etanks, consumes ~50 energy
                               },
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.LowerNorfair,
                                   Name = "Golden Egg",
                                   Address = 0x7D07F,
                                   CanAccess =
                                       have =>
                                   	CanAccessLN(have)
                                   	&& have.Contains(ItemType.SuperMissile)
                                   	&& have.Contains(ItemType.SpeedBooster)
                                   	&& have.Contains(ItemType.ChargeBeam)
                                   	&& CanDefeatDraygon(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Norfair Entrance",
                                   Address = 0x7D2E3,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have)
                                   	&& CanEnterPassages(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Pain",
                                   Address = 0x7D2EB,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.VariaSuit),
                                   // space and screw for casual 50th
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Sova Maze",
                                   Address = 0x7D2FF,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have)
                                   	&& CanEnterPassages(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Sova Chozo - HiJumpBoot",
                                   Address = 0x7D305,
                                   CanAccess =
                                       have =>
                                   	CanLeftSideCrateria(have)
                                   	&& CanEnterPassages(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Factory",
                                   Address = 0x7D27D,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                                   
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "'Croc Power Bombs'",
                                   Address = 0x7D251,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& CanUsePowerBombs(have)
                                   //crumble block should not respawn
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "'Croc Missiles'",
                                   Address = 0x7CFAB,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& have.Contains(ItemType.VariaSuit)
                                   	&& have.Contains(ItemType.WaveBeam)
                                   	&& have.Contains(ItemType.IceBeam)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Pool Party",
                                   Address = 0x7D2C1,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& have.Contains(ItemType.VariaSuit)
                                   	&& have.Contains(ItemType.WaveBeam)
                                   	&& have.Contains(ItemType.IceBeam)
                                   	&& have.Contains(ItemType.SpeedBooster)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Trip to the Dentist",
                                   Address = 0x7D389,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& have.Contains(ItemType.VariaSuit)
                                   	&& have.Contains(ItemType.WaveBeam)
                                   	&& have.Contains(ItemType.IceBeam)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Borderlands",
                                   Address = 0x7D2AB,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have),
                                   //hellrun room, can have etank requirement
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Lava Lake",
                                   Address = 0x7D375,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have),
                                   //hellrun room, can have etank requirement
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Norfair Reserves",
                                   Address = 0x7D333,
                                   CanAccess =
                                       have =>
                                   	//~300 energy heat/lava dive
                                   	CanAccessUpperNorfair(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Lava Chozo",
                                   Address = 0x7D361,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& have.Contains(ItemType.GrappleBeam),
                                   //hellrun room, single
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Guardhouse - Ice Beam",
                                   Address = 0x7D443,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Lava Dive",
                                   Address = 0x7D20B,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& ((have.Contains(ItemType.VariaSuit)
                                   	    && have.Contains(ItemType.SpringBall))
                                   		//etank req for lava dive 1000 energy to collect item and survive
                                   		//500 energy to check the item
                                   		//or 300 energy to check using main LN Path
                                   		|| (have.Contains(ItemType.GravitySuit))),
                                   		//can result in softlock if travel through tunnel w/out springball suitless
                                   		
                                   		//following room is exactly the same setup as vanilla lava dive room at first glance
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Wave Beam",
                                   Address = 0x7D4B5,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& have.Contains(ItemType.VariaSuit)
                                   	&& have.Contains(ItemType.SuperMissile),
                                   //the escape requires speedbooster, IBJ, or wave beam
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "dragon lake i guess",
                                   Address = 0x7D421,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                                   //moderate hellrun, etank req needed
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "The Hideout",
                                   Address = 0x7D3D7,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have),
                                   //enemies do lots of damage + small lava segment
                                   //should have etank limit
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "that's cool",
                                   Address = 0x7D40B,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& have.Contains(ItemType.VariaSuit)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Fire Island",
                                   Address = 0x7D403,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& have.Contains(ItemType.VariaSuit)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "SpikeSuit Chozo",
                                   Address = 0x7D39D,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& have.Contains(ItemType.VariaSuit)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Farm Chozo",
                                   Address = 0x7D461,
                                   CanAccess =
                                       have =>
                                   	CanAccessUpperNorfair(have)
                                   	&& have.Contains(ItemType.VariaSuit)
                                   	&& have.Contains(ItemType.IceBeam)
                                   	&& have.Contains(ItemType.SpeedBooster)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.LowerNorfair,
                                   Name = "Ridley Etank",
                                   Address = 0x7D13B,
                                   CanAccess =
                                       have =>
                                   	CanAccessLN(have)
                                   	&& have.Contains(ItemType.SuperMissile)
                                   	&& have.Contains(ItemType.SpeedBooster)
                                   	&& have.Contains(ItemType.GrappleBeam)
                                   	&& have.Contains(ItemType.ChargeBeam),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.LowerNorfair,
                                   Name = "Pink Cage",
                                   Address = 0x7D133,
                                   CanAccess =
                                       have =>
                                   	CanAccessLN(have)
                                   	&& have.Contains(ItemType.SuperMissile)
                                   	&& have.Contains(ItemType.SpeedBooster)
                                   	&& have.Contains(ItemType.GrappleBeam),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.LowerNorfair,
                                   Name = "Bird Cage",
                                   Address = 0x7CFFD,
                                   CanAccess =
                                       have =>
                                   	CanAccessLN(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.LowerNorfair,
                                   Name = "Bubble Road of Pain",
                                   Address = 0x7CFD1,
                                   CanAccess =
                                       have =>
                                   	CanAccessLN(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.LowerNorfair,
                                   Name = "ILoveSupers3",
                                   Address = 0x7D087,
                                   CanAccess =
                                       have =>
                                   	CanAccessLN(have)
                                   	&& have.Contains(ItemType.SuperMissile)
                                   	&& have.Contains(ItemType.SpeedBooster),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.WreckedShip,
                                   Name = "ILoveSuperBlocks2",
                                   Address = 0x7D5ED,
                                   CanAccess =
                                       have =>
                                   	CanDefeatPhantoon(have)
                                   	&& have.Contains(ItemType.SuperMissile)
                                   	&& have.Contains(ItemType.SpaceJump)
                                   	&& have.Contains(ItemType.WaveBeam),
                                   //ibj, hj+wj, space jump
                                   //potential softlock if no supers left
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.WreckedShip,
                                   Name = "Chozo Jail 1",
                                   Address = 0x7D573,
                                   CanAccess =
                                       have =>
                                   	CanDefeatPhantoon(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.WreckedShip,
                                   Name = "Broken Hold",
                                   Address = 0x7D68D,
                                   CanAccess =
                                       have =>
                                   	CanDefeatPhantoon(have)
                                   	&& have.Contains(ItemType.GravitySuit)
                                   	&& have.Contains(ItemType.SpeedBooster),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.WreckedShip,
                                   Name = "Gutterball",
                                   Address = 0x7D52D,
                                   CanAccess =
                                       have =>
                                   	CanDefeatPhantoon(have)
                                   	&& CanUsePowerBombs(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.WreckedShip,
                                   Name = "Pancake Drop",
                                   Address = 0x7D71B,
                                   CanAccess =
                                       have =>
                                   	CanDefeatPhantoon(have)
                                   	&& CanEnterPassages(have)
                                   	&& have.Contains(ItemType.HiJumpBoots)
                                   	&& have.Contains(ItemType.IceBeam)
                                   	&& CanUsePowerBombs(have),
                           },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.WreckedShip,
                                   Name = "Gravity Suit",
                                   Address = 0x7D4ED,
                                   CanAccess =
                                       have =>
                                   	CanDefeatPhantoon(have)
                                   	&& have.Contains(ItemType.GrappleBeam)
                                   	&& CanEnterPassages(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.WreckedShip,
                                   Name = "Kitchen",
                                   Address = 0x7D7E1,
                                   CanAccess =
                                       have =>
                                   	CanEnterWS(have)
                                   	
                                   	&& (have.Contains(ItemType.SpringBall)
                                   	
                                   	|| (have.Contains(ItemType.GravitySuit)
                                   	        && CanEnterPassages(have))),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.WreckedShip,
                                   Name = "The Tenderizer",
                                   Address = 0x7D6EF,
                                   CanAccess =
                                       have =>
                                   	CanEnterWS(have)
                                   	&& CanEnterPassages(have)
                                   	&& have.Contains(ItemType.HiJumpBoots),
                                   // anything above needs ice beam or something to get up the tenderizer
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.WreckedShip,
                                   Name = "POOPDECK",
                                   Address = 0x7D73B,
                                   CanAccess =
                                       have =>
                                   	CanDefeatPhantoon(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.WreckedShip,
                                   Name = "Piranha Tank",
                                   Address = 0x7D77B,
                                   CanAccess =
                                       have =>
                                   	CanDefeatPhantoon(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Speedbooster Chozo",
                                   Address = 0x7D8F9,
                                   CanAccess =
                                       have =>
                                   	CanAccessTwinStatues(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.GravitySuit),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Shaktool Reserves",
                                   Address = 0x7D859,
                                   CanAccess =
                                       have =>
                                   	CanAccessTwinStatues(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.GravitySuit),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Sandfall Secret",
                                   Address = 0x7D879,
                                   CanAccess =
                                       have =>
                                   	CanAccessTwinStatues(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.GravitySuit),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Super Chozo",
                                   Address = 0x7D975,
                                   CanAccess =
                                       have =>
                                   	CanAccessTwinStatues(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.GravitySuit),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Sunken Save Station",
                                   Address = 0x7D989,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Pink Pirate House",
                                   Address = 0x7D9CB,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have)
                                   	&& have.Contains(ItemType.SpringBall),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Everest",
                                   Address = 0x7D9F1,
                                   CanAccess =
                                       have =>
                                   	have.Contains(ItemType.GravitySuit)
                                   	&& ((CanAccessTwinStatues(have)
                                   	&& CanUsePowerBombs(have)
                                   	&& have.Contains(ItemType.HiJumpBoots))
                                   	
                                   	|| CanFullSuitlessMaridia(have)),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Mama Turtle - Left",
                                   Address = 0x7DA1B,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have)
                                   	&& have.Contains(ItemType.GravitySuit)
                                   	&& have.Contains(ItemType.SpeedBooster),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Mama Turtle - Right",
                                   Address = 0x7DA15,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Springball Maze",
                                   Address = 0x7D967,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have)
                                   	&& have.Contains(ItemType.GravitySuit)
                                   	&& have.Contains(ItemType.SpeedBooster),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Tor",
                                   Address = 0x7D9A7,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Jail Chozo 2",
                                   Address = 0x7DAD9,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have)
                                   	&& have.Contains(ItemType.GravitySuit)
                                   	&& have.Contains(ItemType.SpeedBooster)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "ILoveSuperBlocks 4",
                                   Address = 0x7DA55,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have)
                                   	&& have.Contains(ItemType.SuperMissile),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Fortress",
                                   Address = 0x7DA81,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have)
                                   	&& have.Contains(ItemType.WaveBeam),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Eden",
                                   Address = 0x7DABD,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have)
                                   	&& have.Contains(ItemType.SpeedBooster),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Purple Guy",
                                   Address = 0x7DAC5,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Pre-Crumble City - The Fall",
                                   Address = 0x7DC19,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have),
                                   // can be an alternate path from WS phantoon
                                   // which has less or different requirements
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Plasma Beam",
                                   Address = 0x7DC2D,
                                   CanAccess =
                                       have =>
                                   	CanDefeatDraygon(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Jail Bird",
                                   Address = 0x7DBD9,
                                   CanAccess =
                                       have =>
                                   	CanDefeatDraygon(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Evidence",
                                   Address = 0x7DBE7,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "The Farmhouse",
                                   Address = 0x7D93B,
                                   CanAccess =
                                       have =>
                                   	(CanFullSuitlessMaridia(have)
                                   	 && have.Contains(ItemType.PlasmaBeam))
                                   	
                                   	|| (have.Contains(ItemType.GravitySuit)
                                   	&& have.Contains(ItemType.ScrewAttack)),
                                   // escape suitless requires HJ and Ice
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Sandpit",
                                   Address = 0x7D923,
                                   CanAccess =
                                       have =>
                                   	CanFullSuitlessMaridia(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Space Jump",
                                   Address = 0x7DBD1,
                                   CanAccess =
                                       have =>
                                   	CanDefeatDraygon(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Pipe Dream",
                                   Address = 0x7DB51,
                                   CanAccess =
                                       have =>
                                   	CanDefeatDraygon(have),
                               },
							   
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Maridia,
                                   Name = "Grapple Climb",
                                   Address = 0x7DB7D,
                                   CanAccess =
                                       have =>
                                   	CanDefeatDraygon(have),
                                   // technically just defeat botwoon, but might be really difficult suitless
                              },	
            };
        }
          private static bool CanIBJ(List<ItemType> have)
        {

			return have.Contains(ItemType.MorphingBall)
				&& have.Contains(ItemType.Bomb);
		} 
 private static bool CanEnterPassages(List<ItemType> have)
        {

			return have.Contains(ItemType.MorphingBall)
 	        && (have.Contains(ItemType.Bomb)
 	            || have.Contains(ItemType.PowerBomb));
		}
 private static bool CanLeftSideCrateria(List<ItemType> have)
        {

			return CanOpenMissileDoors(have)
               	&& (have.Contains(ItemType.SpeedBooster)
               	    || (have.Contains(ItemType.WaveBeam) // or GGG for higher difficulty
				        && CanEnterPassages(have)));
		}
 private static bool CanUsePowerBombs(List<ItemType> have)
        {

 	return have.Contains(ItemType.MorphingBall)
 		&& have.Contains(ItemType.PowerBomb);
		}
 private static bool CanOpenMissileDoors(List<ItemType> have)
        {

 	return have.Contains(ItemType.Missile)
 		|| have.Contains(ItemType.SuperMissile);
		}
 private static bool CanEnterWS(List<ItemType> have)
        {

 	return CanLeftSideCrateria(have)
 		&& have.Contains(ItemType.SuperMissile)
 		//2 paths, main
 		&& (have.Contains(ItemType.GravitySuit)
 		&& have.Contains(ItemType.GrappleBeam))
 		//2 paths, intended/pancake house, requires damageboost or HJ/ICE
		|| 
		   	(have.Contains(ItemType.SpeedBooster)
 		 && have.Contains(ItemType.GrappleBeam)
		   	&& CanEnterPassages(have)
		   	&& have.Contains(ItemType.IceBeam)
		   	&& have.Contains(ItemType.SuperMissile)
		   	&& CanLeftSideCrateria(have));
		}
 private static bool CanEnterEastBrinstar(List<ItemType> have)
        {

 	return CanEnterPassages(have)                        	
		&& (CanUsePowerBombs(have)
 		    || CanOpenMissileDoors(have));
		}
 
 private static bool CanAccessTwinStatues(List<ItemType> have)
        {

 	return (CanEnterEastBrinstar(have)
 		&& CanEnterPassages(have)
 		&& CanUsePowerBombs(have))
 		
 		&& ((have.Contains(ItemType.GrappleBeam)
 		     && (have.Count(x => x == ItemType.SuperMissile) >= 4)
 		     || have.Contains(ItemType.ChargeBeam)
 		     && have.Contains(ItemType.WaveBeam))
 		//count 4 or + charge
 		    
 		    || (have.Contains(ItemType.GravitySuit)
 		         && have.Contains(ItemType.SpeedBooster)));
		}
                                   	
 private static bool CanDefeatKraid(List<ItemType> have)
        {

 	return CanAccessTwinStatues(have)
	       	&& CanEnterPassages(have)
 		&& have.Contains(ItemType.SuperMissile)
 		     && have.Count(x => x == ItemType.EnergyTank) >= 5;
		}
                                   	
 private static bool CanDefeatPhantoon(List<ItemType> have)
        {

 	return CanEnterWS(have)
 		&& have.Contains(ItemType.IceBeam)
 		&& have.Contains(ItemType.HiJumpBoots)
 		&& have.Count(x => x == ItemType.EnergyTank) >= 5
 		&& CanEnterPassages(have);
 	//can set etank limiter, etc
		}                                   	
 private static bool CanAccessUpperNorfair(List<ItemType> have)
        {

 	return CanLeftSideCrateria(have)
   	&& CanEnterPassages(have)
 		&& have.Contains(ItemType.HiJumpBoots)
 		&& have.Count(x => x == ItemType.EnergyTank) >= 5
 		&& have.Contains(ItemType.VariaSuit);
 		// main room requires hjb or ibj or clever ice use
 		//should choose between two paths to norfair, either twin statues from
 		//leftsidecrateria or eastbrinstar
		}                                   	
 private static bool CanDefeatGT(List<ItemType> have)
        {

 	return CanDefeatDraygon(have)
 		&& have.Count(x => x == ItemType.EnergyTank) >= 10;
		}
                                   	
 private static bool CanAccessLN(List<ItemType> have)
        {

 	return CanAccessUpperNorfair(have)
 		&& CanDefeatGT(have)
 		&& have.Contains(ItemType.SpaceJump)
 		//spacejump required for chozo acid statue
 		//tank limiter for no grav LN and grav LN because so much dmg
 		&& CanUsePowerBombs(have)
 		&& have.Count(x => x == ItemType.EnergyTank) >= 10
 		&& (have.Contains(ItemType.HiJumpBoots)
 		
 		    || have.Contains(ItemType.GravitySuit));
		}  
                                   	
 private static bool CanFullSuitlessMaridia(List<ItemType> have)
        {

 	return CanAccessTwinStatues(have)
 		&& CanUsePowerBombs(have)
 		&& have.Contains(ItemType.IceBeam)
 		&& have.Contains(ItemType.ChargeBeam)
 		&& have.Contains(ItemType.GrappleBeam)
 		&& have.Contains(ItemType.GravitySuit);
 		// specific items call for speedbooster or springball
		} 
                                   	
 private static bool CanDefeatDraygon(List<ItemType> have)
        {

 	return CanFullSuitlessMaridia(have)
 		&& have.Contains(ItemType.GravitySuit)
 		&& have.Contains(ItemType.SpeedBooster)
 		&& have.Contains(ItemType.SuperMissile)
 		&& have.Count(x => x == ItemType.EnergyTank) >= 10;
		}   
                                   	
              
 
                                   	


        public RomLocationsCasual()
        {
            ResetLocations();
        }

        public List<Location> GetAvailableLocations(List<ItemType> haveItems)
        {
            var retVal = (from Location location in Locations where (location.Item == null) && location.CanAccess(haveItems) select location).ToList();
            // var currentWeight = (from item in retVal orderby item.Weight descending select item.Weight).First() + 1;
            var currentWeight = 50;

            foreach (var item in retVal.Where(item => item.Weight == 0))
            {
                item.Weight = currentWeight;
            }

            var addedItems = new List<List<Location>>();
            for (int i = 1; i < currentWeight; i++)
            {
                addedItems.Add(retVal.Where(x => x.Weight > i).ToList());
            }

            foreach (var list in addedItems)
            {
                retVal.AddRange(list);
            }

            return retVal;
        }

        public List<Location> GetUnavailableLocations(List<ItemType> haveItems)
        {
            return (from Location location in Locations where location.Item == null && !location.CanAccess(haveItems) select location).ToList();
        }

        public void TryInsertCandidateItem(List<Location> currentLocations, List<ItemType> candidateItemList, ItemType candidateItem)
        {
			// only try gravity if gravity is okay in this spot
			// only insert multiples of an item into the candidate list if we aren't looking at the morph ball slot.
			if (currentLocations.All(x => x.Name != "Morphing Ball") || !candidateItemList.Contains(candidateItem))
            {
                candidateItemList.Add(candidateItem);
            }
        }

        public int GetInsertedLocation(List<Location> currentLocations, ItemType insertedItem, SeedRandom random)
        {
            return random.Next(currentLocations.Count);
        }

        public ItemType GetInsertedItem(List<Location> currentLocations, List<ItemType> itemPool, SeedRandom random)
        {
            return itemPool[random.Next(itemPool.Count)];
        }

        public List<ItemType> GetItemPool(SeedRandom random)
        {
            return new List<ItemType>
                       {
						   //14 Etanks
						   //4 reserves
						   //16 major items
						   //56 missiles
						   //10 power bombs
						   //10 supers
						   //---110 items
                           ItemType.MorphingBall,
                           ItemType.Bomb,
                           ItemType.ChargeBeam,
                           ItemType.Spazer,
                           ItemType.VariaSuit,
                           ItemType.HiJumpBoots,
                           ItemType.SpeedBooster,
                           ItemType.WaveBeam,
                           ItemType.GrappleBeam,
                           ItemType.GravitySuit,
                           ItemType.SpaceJump,
                           ItemType.SpringBall,
                           ItemType.PlasmaBeam,
                           ItemType.IceBeam,
                           ItemType.ScrewAttack,
                           ItemType.XRayScope,
                           ItemType.ReserveTank,
                           ItemType.ReserveTank,
                           ItemType.ReserveTank,
                           ItemType.ReserveTank,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,                           
						   ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,                           
						   ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,                           
						   ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
						   ItemType.Missile,
						   ItemType.Missile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                       };
        }
    }
}
