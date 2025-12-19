namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class Perfumery : MerchantsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Perfume, 10);
	public override Material[] Consumption { get; } = [new(eGood.Ambergris, 1), new(eGood.Brandy, 2), new(eGood.RoseWater, 2)];
	private protected override string IconName => "Perfumery.png";
}