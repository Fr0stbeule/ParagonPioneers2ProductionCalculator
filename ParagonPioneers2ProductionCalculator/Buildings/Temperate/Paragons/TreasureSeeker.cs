using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class TreasureSeeker : ParagonsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.GoldJewelry, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(2, new River());
	private protected override string IconName => "TreasureSeeker.png";
}