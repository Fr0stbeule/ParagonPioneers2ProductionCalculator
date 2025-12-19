using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Northern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class RockSaltMine : NorthernBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.RockSalt, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new Salt());
	private protected override string IconName => "RockSaltMine.png";
}