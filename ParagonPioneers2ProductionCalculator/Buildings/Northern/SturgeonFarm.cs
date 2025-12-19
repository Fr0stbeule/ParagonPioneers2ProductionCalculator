using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Northern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;
internal class SturgeonFarm : NorthernBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Sturgeon, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(2, new River());
	private protected override string IconName => "SturgeonFarm.png";
}