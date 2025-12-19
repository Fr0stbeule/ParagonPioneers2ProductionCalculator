using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Northern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class Whaler : NorthernBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.SpermWhale, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new SpermWhale());
	private protected override string IconName => "Whaler.png";
}