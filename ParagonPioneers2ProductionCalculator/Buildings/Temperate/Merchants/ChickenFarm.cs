using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class ChickenFarm : MerchantsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Egg, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(8, new Grass());
	private protected override string IconName => "ChickenFarm.png";
}