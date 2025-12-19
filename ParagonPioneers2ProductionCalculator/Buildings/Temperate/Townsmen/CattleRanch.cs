using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class CattleRanch : TownsmenBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Cattle, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(8, new Grass());
	private protected override string IconName => "CattleRanch.png";
}