namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class KnightBarracks : MerchantsBuilding
{
	public override double Minutes => 20;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Militia, 4), new(eGood.IronSword, 1)];
	private protected override string IconName => "KnightBarracks.png";
}