namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class ParagonsResidence : ParagonsBuilding, IPopulationBuilding
{
	public override double Minutes => 60;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.TobaccoPipe, 30d / 9000 * 3600), new(eGood.MeatPie, 30d / 8000 * 3600), new(eGood.Caviar, 30d / 36000 * 3600), new(eGood.GoldJewelry, 30d / 12400 * 3600), new(eGood.Perfume, 30d / 12400 * 3600), new(eGood.Shoe, 30d / 6120 * 3600), new(eGood.Glasses, 30d / 6120 * 3600), new(eGood.Book, 30d / 17485 * 3600), new(eGood.ChocolateCandy, 30d / 10200 * 3600), new(eGood.NobleGarment, 30d / 17485 * 3600), new(eGood.Wine, 30d / 8160 * 3600)];
	private protected override string IconName => "ParagonsResidence.png";
}