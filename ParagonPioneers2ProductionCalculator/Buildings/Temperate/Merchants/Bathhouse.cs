namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class Bathhouse : MerchantsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Fabric, 1), new(eGood.Soap, 1)];
	private protected override string IconName => "Bathhouse.png";
}