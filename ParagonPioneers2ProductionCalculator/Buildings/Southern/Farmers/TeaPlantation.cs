using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class TeaPlantation : FarmersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Tea, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(4, new Tea());
	private protected override string IconName => "TeaPlantation.png";
}