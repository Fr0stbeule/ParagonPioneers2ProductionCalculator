using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class Winery : ParagonsBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = new(eGood.Grapes, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(12, new Wine());
	private protected override string IconName => "Winery.png";
}