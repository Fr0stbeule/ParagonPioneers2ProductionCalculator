using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.HighSeas;

namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Adepts;

internal class PegasusFarm : AdeptsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Pegasus, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(20, new Grass());
	private protected override string IconName => "PegasusFarm.png";
}