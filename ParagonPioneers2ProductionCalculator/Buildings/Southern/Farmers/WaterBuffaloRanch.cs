using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class WaterBuffaloRanch : FarmersBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.WaterBuffalo, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(2, new Grass());
	private protected override string IconName => "WaterBuffaloRanch.png";
}