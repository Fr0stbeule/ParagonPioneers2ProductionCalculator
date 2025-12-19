namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Archmages;

internal class DruidsAcademy : ArchmagesBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Pelt, 1)];
	private protected override string IconName => "DruidsAcademy.png";
}