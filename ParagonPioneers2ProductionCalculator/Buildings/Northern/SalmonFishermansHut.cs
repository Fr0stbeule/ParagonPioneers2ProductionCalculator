using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Northern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class SalmonFishermansHut : NorthernBuilding
{
	public override double Minutes => 0.75;
	public override Material? Production { get; } = new(eGood.Fish, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(4, new Coast());
	private protected override string IconName => "SalmonFishermansHut.png";
}