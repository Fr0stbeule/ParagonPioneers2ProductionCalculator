using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class FlowerHouse : WorkersBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = new(eGood.FuneralFlowers, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(20, new Grass());
	private protected override string IconName => "FlowerHouse.png";
}