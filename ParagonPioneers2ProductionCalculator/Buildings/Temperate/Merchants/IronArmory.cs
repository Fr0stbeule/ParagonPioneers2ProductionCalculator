using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class IronArmory : MerchantsBuilding
{
	public override double Minutes => 16;
	public override Material? Production { get; } = new(eGood.IronSword, 2);
	public override Material[] Consumption { get; } = [new(eGood.Coal, 1), new(eGood.IronIngot, 2)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "IronArmory.png";
}