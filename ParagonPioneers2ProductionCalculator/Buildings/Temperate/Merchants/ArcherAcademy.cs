namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class ArcherAcademy : MerchantsBuilding
{
	public override double Minutes => 20;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Militia, 4), new(eGood.CompositeBow, 1)];
	private protected override string IconName => "ArcherAcademy.png";
}