namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class Butchery : MerchantsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Meat, 4);
	public override Material[] Consumption { get; } = [new(eGood.Salt, 1), new(eGood.Cattle, 2)];
	private protected override string IconName => "Butchery.png";
}