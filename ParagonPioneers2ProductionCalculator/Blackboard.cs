using ParagonPioneers2ProductionCalculator.Buildings;
using ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Adepts;
using ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Apprentices;
using ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Archmages;
using ParagonPioneers2ProductionCalculator.Buildings.Northern;
using ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;
using ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;
using ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;
using ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;
using ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;
using ParagonPioneers2ProductionCalculator.Buildings.Temperate.Pioneers;
using ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

namespace ParagonPioneers2ProductionCalculator;

internal class Blackboard
{
	public Blackboard()
	{
		this.Configuration = this.PioneersBuildings.Cast<AbstractBuilding>()
			.Concat(this.ColonistsBuildings)
			.Concat(this.TownsmenBuildings)
			.Concat(this.MerchantsBuildings)
			.Concat(this.ParagonsBuildings)
			.Concat(this.FarmersBuildings)
			.Concat(this.WorkersBuildings)
			.Concat(this.NorthernBuildings)
			.Concat(this.ApprenticeBuildings)
			.Concat(this.AdeptsBuildings)
			.Concat(this.ArchmagesBuildings)
			.Select(x => new SupplierChoice([x]))
			.ToList();
	}

	public double DifficultyMultiplier { get; set; } = 1;

	public List<SupplierChoice> Configuration { get; }

	public List<PioneersBuilding> PioneersBuildings { get; } =
	[
		new PioneersHut(),
		new Buildings.Temperate.Pioneers.Lumberjack(),
		new SawWorks(),
		new Buildings.Temperate.Pioneers.Sawmill(),
		new Buildings.Temperate.Pioneers.FishermansHut(),
		new Piggery(),
		new PigRanch(),
		new SausageMaker(),
		new CiderMaker(),
		new BootCamp()
	];

	public List<ColonistsBuilding> ColonistsBuildings { get; } =
	[
		new ColonistsHouse(),
		new Stonecutter(),
		new LimeKiln(),
		new MortarBatchWorks(),
		new RenderingWorks(),
		new AshHouse(),
		new SoapMaker(),
		new SheepFarm(),
		new Weaver(),
		new TextileFactory(),
		new WheatFarm(),
		new FlourMill(),
		new FlourWindmill(),
		new Bakery(),
		new Buildings.Temperate.Colonists.Rickyard(),
		new Buildings.Temperate.Colonists.LinseedFarm(),
		new Bowyer(),
		new Buildings.Temperate.Colonists.Ropery(),
		new Buildings.Temperate.Colonists.CopperMine(),
		new Buildings.Temperate.Colonists.CopperSmelter(),
		new CopperArmory(),
		new CopperAxesmith(),
		new ArcheryRange(),
		new Barracks(),
		new BerserkerHall()
	];

	public List<TownsmenBuilding> TownsmenBuildings { get; } =
	[
		new TownsmensHouse(),
		new BoulderGatherer(),
		new BoilerMaker(),
		new HopFarm(),
		new Malthouse(),
		new Brewery(),
		new Buildings.Temperate.Townsmen.CoalMine(),
		new CharcoalKiln(),
		new BoilingHouse(),
		new Medicus(),
		new CattleRanch(),
		new Furriery(),
		new Buildings.Temperate.Townsmen.RockSaltMine(),
		new Buildings.Temperate.Townsmen.SaltWorks(),
		new Tannery(),
		new StrawberryFarm(),
		new JamMaker(),
		new ChalkMaker(),
		new TownSchool(),
		new Sailmaker(),
		new HorseBreeder(),
		new Paddock(),
		new Longbowyer(),
		new DrumMaker(),
		new RidingArena(),
		new LongbowArcheryRange(),
		new DrummersSchool(),
	];

	public List<MerchantsBuilding> MerchantsBuildings { get; } =
	[
		new MerchantsMansion(),
		new ForestWardensCabin(),
		new Buildings.Temperate.Merchants.IronMine(),
		new Buildings.Temperate.Merchants.IronSmelter(),
		new Toolmaker(),
		new Buildings.Temperate.Merchants.MarbleQuarry(),
		new FeltmakingMill(),
		new HattersShop(),
		new Apiary(),
		new TownHall(),
		new CuringHouse(),
		new PipemakersShop(),
		new ChickenFarm(),
		new Butchery(),
		new PieMaker(),
		new Goldsmith(),
		new Bathhouse(),
		new RoseCultivation(),
		new BrandyDistillery(),
		new EssenceDistillery(),
		new Perfumery(),
		new SugarBeetFarm(),
		new Hospital(),
		new DeepCopperMine(),
		new Buildings.Temperate.Merchants.GoldSmelter(),
		new CoiningPress(),
		new IronArmory(),
		new CrossbowMaker(),
		new CompositeBowyer(),
		new KnightBarracks(),
		new CrossbowShootingRange(),
		new ArcherAcademy(),
	];

	public List<ParagonsBuilding> ParagonsBuildings { get; } =
	[
		new ParagonsResidence(),
		new QuartzQuarry(),
		new Glassworks(),
		new GlaziersWorkshop(),
		new Buildings.Temperate.Paragons.BrassSmelter(),
		new CobblersShop(),
		new LensGrinder(),
		new LanceMaker(),
		new Tiltyard(),
		new PaperMill(),
		new Bookbinder(),
		new HoneyDistillery(),
		new Confectionery(),
		new Chandler(),
		new University(),
		new Winery(),
		new Cooper(),
		new Winepress(),
		new BrocadeSpinningFactory(),
		new OrnateTailor(),
		new Buildings.Temperate.Paragons.Saltern(),
		new TreasureSeeker(),
		new PowderMill(),
		new PlaningMill(),
		new FireworksMaker(),
		new Cokery(),
		new SteelFurnace(),
		new Armorsmith(),
		new CannonFoundry(),
		new MusketMaker(),
		new CuirassierAcademy(),
		new CannoneersSchool(),
		new MusketeerSchool(),
	];

	public List<FarmersBuilding> FarmersBuildings { get; } =
	[
		new FarmersShack(),
		new FiberMaker(),
		new ClayPit(),
		new Brickyard(),
		new BeachFishermansHut(),
		new TeaPlantation(),
		new SugarCanePlantation(),
		new RumDistillery(),
		new SugarMill(),
		new SugarWindmill(),
		new CoffeePlantation(),
		new RoastHouse(),
		new CoffeeHouse(),
		new GoatFarm(),
		new Dairy(),
		new TobaccoPlantation(),
		new CigarManufacturer(),
		new CrocodileRanch(),
		new BallMaker(),
		new SportsGround(),
		new WaterBuffaloRanch(),
		new WhimHouse(),
		new Buildings.Southern.Farmers.Saltern(),
		new Buildings.Southern.Farmers.Ropery(),
		new Buildings.Southern.Farmers.CoalMine(),
		new Buildings.Southern.Farmers.CopperMine(),
		new Buildings.Southern.Farmers.CopperSmelter(),
		new PoleturnersWorkshop(),
		new Apothecary(),
		new PikemenBarracks(),
		new FieldSurgeonHouse()
	];

	public List<WorkersBuilding> WorkersBuildings { get; } =
	[
		new WorkersHouse(),
		new FineWoodLogger(),
		new CacaoPlantation(),
		new Chocolaterie(),
		new GemstoneMine(),
		new Buildings.Southern.Workers.GoldMine(),
		new Buildings.Southern.Workers.GoldSmelter(),
		new GoldPanner(),
		new ArtisticBlacksmith(),
		new CoconutPlantation(),
		new BuffaloButchery(),
		new SoupKitchen(),
		new FlowerHouse(),
		new Cemetery(),
		new SilkPlantation(),
		new SilkTwineMill(),
		new NobleTailor(),
		new IndigoPlantation(),
		new Costumier(),
		new DancingSchool(),
		new Buildings.Southern.Workers.BrassSmelter(),
		new Luthier(),
		new CottonPlantation(),
		new SpinningMill(),
		new Buildings.Southern.Workers.Rickyard(),
		new BuffaloPasture(),
		new NitrateMaker(),
		new GlaiveSmith(),
		new HeraldicArmourer(),
		new GlaiveTemple(),
		new ShieldGuardianTemple()
	];

	public List<NorthernBuilding> NorthernBuildings { get; } =
	[
		new ConiferLumberjack(),
		new Buildings.Northern.MarbleQuarry(),
		new HeatingPlant(),
		new LargeHeatingPlant(),
		new SalmonFishermansHut(),
		new SturgeonFarm(),
		new Buildings.Northern.CoalMine(),
		new Buildings.Northern.RockSaltMine(),
		new Buildings.Northern.SaltWorks(),
		new CaviarFactory(),
		new Whaler(),
		new AmbergrisProduction(),
		new FurTrapper(),
		new Buildings.Northern.CopperMine(),
		new Buildings.Northern.CopperSmelter(),
		new Buildings.Northern.IronMine(),
		new Buildings.Northern.IronSmelter(),
		new Buildings.Northern.GoldMine(),
		new Buildings.Northern.GoldSmelter(),
		new ZincMine(),
		new ZincSmelter(),
		new Buildings.Northern.BrassSmelter(),
		new LeadMine(),
		new LeadSmelter()
	];

	public List<ApprenticeBuilding> ApprenticeBuildings { get; } =
	[
		new ApprenticeDormitory(),
		new Buildings.HighSeas.Apprentices.Lumberjack(),
		new Buildings.HighSeas.Apprentices.Sawmill(),
		new Basaltcutter(),
		new Buildings.HighSeas.Apprentices.FishermansHut(),
		new PotatoFarm(),
		new Buildings.HighSeas.Apprentices.LinseedFarm(),
		new LinenWeaver(),
		new CloakTailoring()
	];

	public List<AdeptsBuilding> AdeptsBuildings { get; } =
	[
		new AdeptsQuarter(),
		new HerbalistsHut(),
		new AlchemySchool(),
		new ArithmancySchool(),
		new PegasusFarm(),
		new SchoolOfMagicalCreatures(),
		new WandmakersShop(),
		new SchoolOfMagicalDefence(),
		new TrophyManufacturer(),
		new TournamentArena()
	];

	public List<ArchmagesBuilding> ArchmagesBuildings { get; } =
	[
		new ArchmagesTower(),
		new Lobsterer(),
		new NobleKitchen(),
		new FineForge(),
		new Library(),
		new ClericsAcademy(),
		new WizardsAcademy(),
		new AllomancersAcademy(),
		new DruidsAcademy(),
		new BardsAcademy(),
		new DraftersAcademy()
	];

	public void UpdateAmount() => this.Configuration.ForEach(x => x.SelectedSupplier.UpdateAmount(this.DifficultyMultiplier));
}