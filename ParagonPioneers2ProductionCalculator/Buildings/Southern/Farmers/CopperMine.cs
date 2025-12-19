using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class CopperMine : FarmersBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.CopperOre, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new CopperOre());
	private protected override string IconName => "CopperMine.png";
}