namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class BuffaloButchery : WorkersBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Meat, 6);
	public override Material[] Consumption { get; } = [new(eGood.Salt, 1), new(eGood.WaterBuffalo, 2)];
	private protected override string IconName => "BuffaloButchery.png";
}