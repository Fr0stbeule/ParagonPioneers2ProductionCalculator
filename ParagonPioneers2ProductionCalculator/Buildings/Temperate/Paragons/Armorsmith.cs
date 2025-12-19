using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class Armorsmith : ParagonsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.ArmoredHorse, 1);
	public override Material[] Consumption { get; } = [new(eGood.Horse, 1), new(eGood.SteelIngot, 1)];
	public override TileRequirement? TileRequirement { get; } = new(1, new River());
	private protected override string IconName => "Armorsmith.png";
}