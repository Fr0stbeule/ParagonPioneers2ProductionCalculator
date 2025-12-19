namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class Furriery : TownsmenBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Hide, 1);
	public override Material[] Consumption { get; } = [new(eGood.Cattle, 1)];
	private protected override string IconName => "Furriery.png";
}