using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.HighSeas;

namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Apprentices;

internal class PotatoFarm : ApprenticeBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Schnapps, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(4, new Potatoes());
	private protected override string IconName => "PotatoFarm.png";
}