namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Adepts;

internal class WandmakersShop : AdeptsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Wand, 4);
	public override Material[] Consumption { get; } = [new(eGood.FineWood, 1)];
	private protected override string IconName => "WandmakersShop.png";
}