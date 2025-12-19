using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class Apiary : MerchantsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Honeycomb, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(8, new Grass());
	private protected override string IconName => "Apiary.png";
}