using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class FiberMaker : FarmersBuilding
{
	public override double Minutes => 0.5;
	public override Material? Production { get; } = new(eGood.Fiber, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(12, new Forest());
	private protected override string IconName => "FiberMaker.png";
}