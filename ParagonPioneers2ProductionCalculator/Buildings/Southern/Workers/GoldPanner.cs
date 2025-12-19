using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class GoldPanner : WorkersBuilding
{
	public override double Minutes => 16;
	public override Material? Production { get; } = new(eGood.GoldIngot, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "GoldPanner.png";
}