namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class PipemakersShop : MerchantsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.TobaccoPipe, 4);
	public override Material[] Consumption { get; } = [new(eGood.FineWood, 1), new(eGood.PipeTobacco, 2)];
	private protected override string IconName => "PipemakersShop.png";
}