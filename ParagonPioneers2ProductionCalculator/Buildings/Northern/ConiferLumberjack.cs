using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Northern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class ConiferLumberjack : NorthernBuilding
{
	public override double Minutes => 0.5;
	public override Material? Production { get; } = new(eGood.Wood, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(14, new Forest());
	private protected override string IconName => "ConiferLumberjack.png";
}