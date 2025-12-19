using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class IronMine : MerchantsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.IronOre, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new IronOre());
	private protected override string IconName => "IronMine.png";
}