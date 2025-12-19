using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Northern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class GoldMine : NorthernBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.GoldOre, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new GoldOre());
	private protected override string IconName => "GoldMine.png";
}