using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class Winepress : ParagonsBuilding
{
	public override double Minutes => 6;
	public override Material? Production { get; } = new(eGood.Wine, 3);
	public override Material[] Consumption { get; } = [new(eGood.Barrel, 1), new(eGood.Grapes, 4)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "Winepress.png";
}