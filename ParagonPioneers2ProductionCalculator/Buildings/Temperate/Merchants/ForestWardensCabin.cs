using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class ForestWardensCabin : MerchantsBuilding
{
	public override double Minutes => 0.5;
	public override Material? Production { get; } = new(eGood.Wood, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(12, new Forest());
	private protected override string IconName => "ForestWardensCabin.png";
}