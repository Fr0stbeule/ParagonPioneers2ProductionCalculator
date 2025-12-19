namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Pioneers;

internal class SausageMaker : PioneersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Sausage, 1);
	public override Material[] Consumption { get; } = [new(eGood.Pig, 1)];
	private protected override string IconName => "SausageMaker.png";
}