using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class CrocodileRanch : FarmersBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Leather, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(2, new River());
	private protected override string IconName => "CrocodileRanch.png";
}