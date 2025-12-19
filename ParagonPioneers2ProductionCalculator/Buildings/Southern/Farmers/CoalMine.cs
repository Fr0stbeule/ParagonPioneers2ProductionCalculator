using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class CoalMine : FarmersBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = new(eGood.Coal, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(4, new Coal());
	private protected override string IconName => "CoalMine.png";
}