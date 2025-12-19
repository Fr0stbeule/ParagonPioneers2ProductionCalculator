using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class SpinningMill : WorkersBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Fabric, 3);
	public override Material[] Consumption { get; } = [new(eGood.Yarn, 4)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "SpinningMill.png";
}