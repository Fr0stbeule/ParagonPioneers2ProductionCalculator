using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class SilkTwineMill : WorkersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.SilkFabric, 1);
	public override Material[] Consumption { get; } = [new(eGood.Silk, 2)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "SilkTwineMill.png";
}