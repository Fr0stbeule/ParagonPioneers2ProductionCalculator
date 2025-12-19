namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class NobleTailor : WorkersBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Garment, 1);
	public override Material[] Consumption { get; } = [new(eGood.SilkFabric, 1)];
	private protected override string IconName => "NobleTailor.png";
}