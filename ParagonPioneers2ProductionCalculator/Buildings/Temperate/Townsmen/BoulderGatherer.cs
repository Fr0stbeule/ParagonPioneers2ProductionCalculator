using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class BoulderGatherer : TownsmenBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = new(eGood.Limestone, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(20, new Grass());
	private protected override string IconName => "BoulderGatherer.png";
}