using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.HighSeas;

namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Apprentices;

internal class LinenWeaver : ApprenticeBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Linen, 3);
	public override Material[] Consumption { get; } = [new(eGood.Fiber, 4)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "LinenWeaver.png";
}