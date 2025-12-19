using ParagonPioneers2ProductionCalculator.Tiles;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class FireworksMaker : ParagonsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Fireworks, 1);
	public override Material[] Consumption { get; } = [new(eGood.Gunpowder, 2), new(eGood.MetalCuttings, 2)];
	public override TileRequirement? TileRequirement => base.TileRequirement;
	private protected override string IconName => "FireworksMaker.png";
}