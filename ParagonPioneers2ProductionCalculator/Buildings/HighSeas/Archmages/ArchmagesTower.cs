namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Archmages;

internal class ArchmagesTower : ArchmagesBuilding, IPopulationBuilding
{
	public override double Minutes => 60;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Tea, 30d / 14000 * 3600), new(eGood.Bread, 30d / 33600 * 3600), new(eGood.Feast, 30d / 17485 * 3600)];
	private protected override string IconName => "ArchmagesTower.png";
}