using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class Saltern : FarmersBuilding
{
	public override double Minutes => 16;
	public override Material? Production { get; } = new(eGood.Salt, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(2, new Coast());
	private protected override string IconName => "Saltern.png";
}