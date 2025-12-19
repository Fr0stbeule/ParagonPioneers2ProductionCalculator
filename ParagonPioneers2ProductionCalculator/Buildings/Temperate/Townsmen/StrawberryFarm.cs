using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class StrawberryFarm : TownsmenBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Strawberries, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(12, new Strawberries());
	private protected override string IconName => "StrawberryFarm.png";
}