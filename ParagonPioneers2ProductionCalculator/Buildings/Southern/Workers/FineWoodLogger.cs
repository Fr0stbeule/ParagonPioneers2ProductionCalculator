using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class FineWoodLogger : WorkersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.FineWood, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(12, new MahagonyForest());
	private protected override string IconName => "FineWoodLogger.png";
}