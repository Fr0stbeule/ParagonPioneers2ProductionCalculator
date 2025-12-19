namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class ArtisticBlacksmith : WorkersBuilding
{
	public override double Minutes => 16;
	public override Material? Production { get; } = new(eGood.Mojo, 4);
	public override Material[] Consumption { get; } = [new(eGood.GoldIngot, 1), new(eGood.Gemstone, 2)];
	private protected override string IconName => "ArtisticBlacksmith.png";
}