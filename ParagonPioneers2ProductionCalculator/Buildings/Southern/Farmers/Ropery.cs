namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class Ropery : FarmersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Ropes, 1);
	public override Material[] Consumption { get; } = [new(eGood.Fiber, 1)];
	private protected override string IconName => "Ropery.png";
}