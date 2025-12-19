using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class FeltmakingMill : MerchantsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Felt, 1);
	public override Material[] Consumption { get; } = [new(eGood.Soap, 2), new(eGood.Yarn, 4)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "FeltmakingMill.png";
}