namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class HeraldicArmourer : WorkersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.LongShield, 1);
	public override Material[] Consumption { get; } = [new(eGood.GoldIngot, 1), new(eGood.FineWood, 2)];
	private protected override string IconName => "HeraldicArmourer.png";
}