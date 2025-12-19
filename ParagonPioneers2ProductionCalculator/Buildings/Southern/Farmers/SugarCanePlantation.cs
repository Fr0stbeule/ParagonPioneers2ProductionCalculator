using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class SugarCanePlantation : FarmersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.SugarCane, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(8, new SugarCane());
	private protected override string IconName => "SugarCanePlantation.png";
}