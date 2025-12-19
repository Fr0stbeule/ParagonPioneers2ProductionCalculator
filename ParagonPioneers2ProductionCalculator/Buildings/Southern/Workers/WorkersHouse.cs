namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class WorkersHouse : WorkersBuilding, IPopulationBuilding
{
	public override double Minutes => 60;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Fish, 20d / 3300 * 3600), new(eGood.Tea, 20d / 6300 * 3600), new(eGood.Rum, 20d / 18900 * 3600), new(eGood.Cheese, 20d / 11300 * 3600), new(eGood.Cigar, 20d / 9500 * 3600), new(eGood.Beer, 20d / 16400 * 3600), new(eGood.Chocolate, 20d / 12300 * 3600), new(eGood.Stew, 20d / 5500 * 3600), new(eGood.Mojo, 20d / 12300 * 3600), new(eGood.Garment, 20d / 12300 * 3600), new(eGood.Guitar, 20d / 8200 * 3600)];
	private protected override string IconName => "WorkersHouse.png";
}