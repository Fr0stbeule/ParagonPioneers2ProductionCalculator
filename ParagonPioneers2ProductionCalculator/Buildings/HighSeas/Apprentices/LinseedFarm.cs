using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.HighSeas;

namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Apprentices;

internal class LinseedFarm : ApprenticeBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Fiber, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(4, new Linseed());
	private protected override string IconName => "LinseedFarm.png";
}