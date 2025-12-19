namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class CopperSmelter : FarmersBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.CopperIngot, 1);
	public override Material[] Consumption { get; } = [new(eGood.Coal,1),new(eGood.CopperOre,1)];
	private protected override string IconName => "CopperSmelter.png";
}