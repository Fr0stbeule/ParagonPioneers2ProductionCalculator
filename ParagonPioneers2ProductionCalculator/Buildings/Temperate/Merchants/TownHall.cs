namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class TownHall : MerchantsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Honeycomb, 1)];
	private protected override string IconName => "TownHall.png";
}