namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class CuirassierAcademy : ParagonsBuilding
{
	public override double Minutes => 30;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Militia, 6), new(eGood.ArmoredHorse, 1)];
	private protected override string IconName => "CuirassierAcademy.png";
}