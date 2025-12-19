using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class FlourMill : ColonistsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Flour, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wheat, 2)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "FlourMill.png";
}