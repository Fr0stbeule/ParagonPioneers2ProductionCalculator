using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class SugarBeetFarm : MerchantsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Sugar, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(20, new SugarBeet());
	private protected override string IconName => "SugarBeetFarm.png";
}