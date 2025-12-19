using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class ClayPit : FarmersBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = new(eGood.Clay, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new Clay());
	private protected override string IconName => "ClayPit.png";
}