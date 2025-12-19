namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class Chandler : ParagonsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Candle, 1);
	public override Material[] Consumption { get; } = [new(eGood.Honeycomb, 3), new(eGood.Fiber, 1)];
	private protected override string IconName => "Chandler.png";
}