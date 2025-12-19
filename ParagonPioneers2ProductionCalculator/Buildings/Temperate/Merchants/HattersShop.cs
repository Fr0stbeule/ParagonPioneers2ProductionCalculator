namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class HattersShop : MerchantsBuilding
{
	public override double Minutes => 16;
	public override Material? Production { get; } = new(eGood.Hat, 4);
	public override Material[] Consumption { get; } = [new(eGood.Felt, 1)];
	private protected override string IconName => "HattersShop.png";
}