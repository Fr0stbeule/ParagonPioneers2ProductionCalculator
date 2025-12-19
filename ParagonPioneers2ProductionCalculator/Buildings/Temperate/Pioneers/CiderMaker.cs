using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Pioneers;

internal class CiderMaker : PioneersBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = new(eGood.Cider, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(12, new AppleTree());
	private protected override string IconName => "CiderMaker.png";
}