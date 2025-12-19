using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Northern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class MarbleQuarry : NorthernBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = new(eGood.Marble, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new Marble());
	private protected override string IconName => "MarbleQuarry.png";
}