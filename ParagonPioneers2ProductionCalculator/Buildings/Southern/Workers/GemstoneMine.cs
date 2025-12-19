using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class GemstoneMine : WorkersBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = new(eGood.Gemstone, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(1, new Gemstone());
	private protected override string IconName => "GemstoneMine.png";
}