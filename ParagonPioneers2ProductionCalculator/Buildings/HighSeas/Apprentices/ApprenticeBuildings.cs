using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.HighSeas;

namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Apprentices;

internal class Basaltcutter : ApprenticeBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Basalt, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new Mountain());
	private protected override string IconName => "Basaltcutter.png";
}