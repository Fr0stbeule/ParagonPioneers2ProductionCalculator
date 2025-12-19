namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class Hospital : MerchantsBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.FishOil, 2)];
	private protected override string IconName => "Hospital.png";
}