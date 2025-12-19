namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Archmages;

internal class BardsAcademy : ArchmagesBuilding
{
	public override double Minutes => 0.25;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Guitar, 1)];
	private protected override string IconName => "BardsAcademy.png";
}