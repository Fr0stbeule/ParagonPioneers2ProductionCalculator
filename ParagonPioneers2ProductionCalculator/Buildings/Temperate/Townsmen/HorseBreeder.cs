using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class HorseBreeder : TownsmenBuilding
{
	public override double Minutes => 6;
	public override Material? Production { get; } = new(eGood.Horse, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(20, new Grass());
	private protected override string IconName => "HorseBreeder.png";
}