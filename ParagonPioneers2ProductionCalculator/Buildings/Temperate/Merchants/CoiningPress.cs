namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class CoiningPress : MerchantsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.GoldIngot, 1)];
	private protected override string IconName => "CoiningPress.png";
}