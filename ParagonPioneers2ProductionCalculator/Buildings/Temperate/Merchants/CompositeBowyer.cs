namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class CompositeBowyer : MerchantsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.CompositeBow, 1);
	public override Material[] Consumption { get; } = [new(eGood.Bow, 1), new(eGood.Cattle, 2)];
	private protected override string IconName => "CompositeBowyer.png";
}