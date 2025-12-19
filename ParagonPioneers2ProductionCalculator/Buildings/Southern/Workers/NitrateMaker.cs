using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class NitrateMaker : WorkersBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Saltpetre, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new Salpetre());
	private protected override string IconName => "NitrateMaker.png";
}