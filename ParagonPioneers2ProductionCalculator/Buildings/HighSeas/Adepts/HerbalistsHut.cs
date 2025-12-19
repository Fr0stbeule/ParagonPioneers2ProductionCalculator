using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.HighSeas;

namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Adepts;

internal class HerbalistsHut : AdeptsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Herbs, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(8, new Forest());
	private protected override string IconName => "HerbalistsHut.png";
}