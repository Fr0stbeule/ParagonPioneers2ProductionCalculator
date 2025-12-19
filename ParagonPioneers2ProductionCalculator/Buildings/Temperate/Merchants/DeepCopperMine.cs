using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class DeepCopperMine : MerchantsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.CopperOre, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new CopperOre());
	private protected override string IconName => "DeepCopperMine.png";
}