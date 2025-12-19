using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class CoffeePlantation : FarmersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.CoffeeBeans, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(8, new CoffeeBeans());
	private protected override string IconName => "CoffeePlantation.png";
}