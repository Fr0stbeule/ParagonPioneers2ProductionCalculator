namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Adepts;

internal class TrophyManufacturer : AdeptsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Trophy, 1);
	public override Material[] Consumption { get; } = [new(eGood.Gemstone, 1), new(eGood.GoldIngot, 1)];
	private protected override string IconName => "TrophyManufacturer.png";
}