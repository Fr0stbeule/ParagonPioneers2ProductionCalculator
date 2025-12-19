namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class Confectionery : ParagonsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.ChocolateCandy, 4);
	public override Material[] Consumption { get; } = [new(eGood.Liqueur, 1), new(eGood.Chocolate, 2)];
	private protected override string IconName => "Confectionery.png";
}