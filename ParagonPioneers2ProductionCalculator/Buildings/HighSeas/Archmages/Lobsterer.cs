using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.HighSeas;

namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Archmages;

internal class Lobsterer : ArchmagesBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Lobster, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new Reef());
	private protected override string IconName => "Lobsterer.png";
}