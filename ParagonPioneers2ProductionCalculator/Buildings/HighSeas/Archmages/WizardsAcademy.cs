namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Archmages;

internal class WizardsAcademy : ArchmagesBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Book, 1)];
	private protected override string IconName => "WizardsAcademy.png";
}