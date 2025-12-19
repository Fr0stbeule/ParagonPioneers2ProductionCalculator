namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class HoneyDistillery : ParagonsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Liqueur, 1);
	public override Material[] Consumption { get; } = [new(eGood.Honeycomb, 2), new(eGood.Brandy, 1)];
	private protected override string IconName => "HoneyDistillery.png";
}