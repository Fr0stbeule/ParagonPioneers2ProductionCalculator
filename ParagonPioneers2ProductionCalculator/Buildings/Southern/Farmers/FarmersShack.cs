namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class FarmersShack : FarmersBuilding, IPopulationBuilding
{
	public static bool BoostProduction { get; set; } = true;
	public override double Minutes => 60;
	public override Material? Production => new(eGood.Slinger, 3 * (BoostProduction ? 1.2 : 1));
	public override Material[] Consumption { get; } = [new(eGood.Fish, 10d / 3300 * 3600), new(eGood.Tea, 10d / 6300 * 3600), new(eGood.Rum, 10d / 18900 * 3600), new(eGood.Cheese, 10d / 11300 * 3600), new(eGood.Cigar, 10d / 9500 * 3600)];
	private protected override string IconName => "FarmersShack.png";
}