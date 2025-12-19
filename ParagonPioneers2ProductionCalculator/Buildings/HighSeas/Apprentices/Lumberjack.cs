using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.HighSeas;

namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Apprentices;

internal class Lumberjack : ApprenticeBuilding
{
	public override double Minutes => 0.25;
	public override Material? Production { get; } = new(eGood.Wood, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(12, new Forest());
	private protected override string IconName => "Lumberjack.png";
}