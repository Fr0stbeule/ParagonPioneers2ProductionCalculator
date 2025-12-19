namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Archmages;

internal class AllomancersAcademy : ArchmagesBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.BrassIngot, 1)];
	private protected override string IconName => "AllomancersAcademy.png";
}