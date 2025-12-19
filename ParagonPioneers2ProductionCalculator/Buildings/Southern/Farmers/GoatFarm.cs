using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class GoatFarm : FarmersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Milk, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(4, new Mountain());
	private protected override string IconName => "GoatFarm.png";
}