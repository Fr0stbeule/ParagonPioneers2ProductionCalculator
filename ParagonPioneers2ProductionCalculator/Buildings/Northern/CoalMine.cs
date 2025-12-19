using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Northern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class CoalMine : NorthernBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = new(eGood.Coal, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new Coal());
	private protected override string IconName => "CoalMine.png";
}