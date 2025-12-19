using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class MarbleQuarry : MerchantsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Marble, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new Marble());
	private protected override string IconName => "MarbleQuarry.png";
}