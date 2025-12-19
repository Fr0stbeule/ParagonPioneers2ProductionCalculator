using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class HopFarm : TownsmenBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Hops, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(8, new Hops());
	private protected override string IconName => "HopFarm.png";
}