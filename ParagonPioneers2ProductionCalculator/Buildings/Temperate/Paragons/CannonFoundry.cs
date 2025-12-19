using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class CannonFoundry : ParagonsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Cannon, 1);
	public override Material[] Consumption { get; } = [new(eGood.Gunpowder, 1), new(eGood.SteelIngot, 1)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "CannonFoundry.png";
}