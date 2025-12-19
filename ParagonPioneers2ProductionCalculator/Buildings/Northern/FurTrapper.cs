using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Northern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class FurTrapper : NorthernBuilding
{
	public override double Minutes => 6;
	public override Material? Production { get; } = new(eGood.Pelt, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(7, new Grass());
	private protected override string IconName => "FurTrapper.png";
}