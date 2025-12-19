namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Pioneers;

internal class BootCamp : PioneersBuilding
{
	public override double Minutes => 5;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Militia, 1), new(eGood.Plank, 4)];
	private protected override string IconName => "BootCamp.png";
}