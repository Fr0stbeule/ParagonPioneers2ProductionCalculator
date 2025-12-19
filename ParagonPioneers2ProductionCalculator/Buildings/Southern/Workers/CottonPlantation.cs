using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class CottonPlantation : WorkersBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = new(eGood.Yarn, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(8, new Cotton());
	private protected override string IconName => "CottonPlantation.png";
}