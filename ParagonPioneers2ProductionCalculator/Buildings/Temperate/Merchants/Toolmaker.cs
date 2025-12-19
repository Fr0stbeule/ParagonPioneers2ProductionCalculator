namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class Toolmaker : MerchantsBuilding
{
	public override double Minutes => 16;
	public override Material? Production { get; } = new(eGood.Tools, 4);
	public override Material[] Consumption { get; } = [new(eGood.Coal, 1), new(eGood.IronIngot, 2)];
	private protected override string IconName => "Toolmaker.png";
}