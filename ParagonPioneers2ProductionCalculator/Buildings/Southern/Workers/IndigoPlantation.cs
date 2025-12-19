using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class IndigoPlantation : WorkersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Dye, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(8, new Indigo());
	private protected override string IconName => "IndigoPlantation.png";
}