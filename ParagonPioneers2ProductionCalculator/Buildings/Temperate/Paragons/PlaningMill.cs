using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class PlaningMill : ParagonsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.MetalCuttings, 2);
	public override Material[] Consumption { get; } = [new(eGood.ZincIngot, 1), new(eGood.IronIngot, 1), new(eGood.CopperIngot, 1)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "PlaningMill.png";
}