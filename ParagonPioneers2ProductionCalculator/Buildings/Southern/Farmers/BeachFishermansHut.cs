using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class BeachFishermansHut : FarmersBuilding
{
	public static bool BoostProduction { get; set; } = true;
	public override double Minutes => 1.5;
	public override Material? Production { get; } = new(eGood.Fish, 1 * (BoostProduction ? 2 : 1));
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(4, new Coast());
	private protected override string IconName => "BeachFishermansHut.png";
}