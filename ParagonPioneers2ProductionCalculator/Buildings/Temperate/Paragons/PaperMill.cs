using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class PaperMill : ParagonsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Paper, 2);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 2), new(eGood.Quicklime, 1)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "PaperMill.png";
}