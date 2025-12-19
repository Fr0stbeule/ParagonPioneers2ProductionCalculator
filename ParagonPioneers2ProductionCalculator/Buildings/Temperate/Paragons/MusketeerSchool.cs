namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class MusketeerSchool : ParagonsBuilding
{
	public override double Minutes => 30;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Militia, 6), new(eGood.Musket, 1)];
	private protected override string IconName => "MusketeerSchool.png";
}