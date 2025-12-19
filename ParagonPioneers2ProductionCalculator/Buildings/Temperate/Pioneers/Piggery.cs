using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Pioneers;

internal class Piggery : PioneersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Pig, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(4, new Grass());
	private protected override string IconName => "Piggery.png";
}