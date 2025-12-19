namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class CannoneersSchool : ParagonsBuilding
{
	public override double Minutes => 30;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Militia, 6), new(eGood.Cannon, 1)];
	private protected override string IconName => "CannoneersSchool.png";
}