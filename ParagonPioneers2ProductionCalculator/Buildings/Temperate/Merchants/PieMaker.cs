namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class PieMaker : MerchantsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.MeatPie, 4);
	public override Material[] Consumption { get; } = [new(eGood.Meat, 2), new(eGood.Flour, 1), new(eGood.Egg, 3)];
	private protected override string IconName => "PieMaker.png";
}