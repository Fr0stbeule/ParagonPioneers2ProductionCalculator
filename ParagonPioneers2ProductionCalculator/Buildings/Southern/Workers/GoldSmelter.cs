namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class GoldSmelter : WorkersBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.GoldIngot, 1);
	public override Material[] Consumption { get; } = [new(eGood.Fiber, 4), new(eGood.GoldOre, 1)];
	private protected override string IconName => "GoldSmelter.png";
}