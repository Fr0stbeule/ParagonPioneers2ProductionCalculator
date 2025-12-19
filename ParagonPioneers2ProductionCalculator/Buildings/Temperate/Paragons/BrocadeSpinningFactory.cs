using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class BrocadeSpinningFactory : ParagonsBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = new(eGood.BrocadeFabric, 1);
	public override Material[] Consumption { get; } = [new(eGood.GoldIngot, 1), new(eGood.SilkFabric, 1)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "BrocadeSpinningFactory.png";
}