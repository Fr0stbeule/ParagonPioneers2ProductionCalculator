using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class SheepFarm : ColonistsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Yarn, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(4, new Grass());
	private protected override string IconName => "SheepFarm.png";
}