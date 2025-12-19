namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class Chocolaterie : WorkersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Chocolate, 3);
	public override Material[] Consumption { get; } = [new(eGood.Sugar, 1), new(eGood.Cacao, 3)];
	private protected override string IconName => "Chocolaterie.png";
}