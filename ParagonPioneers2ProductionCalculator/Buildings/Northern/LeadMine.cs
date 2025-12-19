using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Northern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class LeadMine : NorthernBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.LeadOre, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new Lead());
	private protected override string IconName => "LeadMine.png";
}