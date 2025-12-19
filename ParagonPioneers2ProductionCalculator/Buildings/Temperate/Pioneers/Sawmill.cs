using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Pioneers;

internal class Sawmill : PioneersBuilding
{
	public override double Minutes => 0.5;
	public override Material? Production { get; } = new(eGood.Plank, 3);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 2)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "Sawmill.png";
}