namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class CuringHouse : MerchantsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.PipeTobacco, 1);
	public override Material[] Consumption { get; } = [new(eGood.Honeycomb, 1), new(eGood.Tobacco, 2)];
	private protected override string IconName => "CuringHouse.png";
}