namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class EssenceDistillery : MerchantsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.RoseWater, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 4), new(eGood.Rose, 4)];
	private protected override string IconName => "EssenceDistillery.png";
}