using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class Stonecutter : ColonistsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Limestone, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new Mountain());
	private protected override string IconName => "Stonecutter.png";
}