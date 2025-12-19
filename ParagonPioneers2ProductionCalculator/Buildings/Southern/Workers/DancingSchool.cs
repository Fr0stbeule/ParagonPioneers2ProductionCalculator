namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class DancingSchool : WorkersBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Costume, 1)];
	private protected override string IconName => "DancingSchool.png";
}