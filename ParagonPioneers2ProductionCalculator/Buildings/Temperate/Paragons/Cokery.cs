namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class Cokery : ParagonsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Coke, 1);
	public override Material[] Consumption { get; } = [new(eGood.Coal, 2)];
	private protected override string IconName => "Cokery.png";
}