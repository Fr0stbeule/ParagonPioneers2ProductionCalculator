using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class LinseedFarm : ColonistsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Fiber, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(5, new Linseed());
	private protected override string IconName => "LinseedFarm.png";
}