namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Archmages;

internal class NobleKitchen : ArchmagesBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Feast, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wine, 1), new(eGood.Lobster, 1)];
	private protected override string IconName => "NobleKitchen.png";
}