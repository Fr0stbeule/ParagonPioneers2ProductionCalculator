using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class MortarBatchWorks : ColonistsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Mortar, 1);
	public override Material[] Consumption { get; } = [new(eGood.Quicklime, 1)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "MortarBatchWorks.png";
}