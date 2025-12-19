using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class SugarMill : FarmersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Sugar, 1);
	public override Material[] Consumption { get; } = [new(eGood.SugarCane, 2)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "SugarMill.png";
}