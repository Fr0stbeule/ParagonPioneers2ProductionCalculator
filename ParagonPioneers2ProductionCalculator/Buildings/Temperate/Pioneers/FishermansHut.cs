using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Pioneers;

internal class FishermansHut : PioneersBuilding
{
	public static bool BoostProduction { get; set; } = true;
	public override double Minutes => 1.5;
	public override Material? Production => new(eGood.Fish, 1 * (BoostProduction ? 2 : 1));
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(4, new Water());
	private protected override string IconName => "FishermansHut.png";
}