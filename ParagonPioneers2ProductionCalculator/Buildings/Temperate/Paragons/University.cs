namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class University : ParagonsBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Candle, 1)];
	private protected override string IconName => "University.png";
}