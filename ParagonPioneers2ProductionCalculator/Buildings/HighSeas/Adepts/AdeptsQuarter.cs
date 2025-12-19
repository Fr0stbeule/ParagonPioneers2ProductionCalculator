namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Adepts;

internal class AdeptsQuarter : AdeptsBuilding, IPopulationBuilding
{
	public override double Minutes => 60;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Fish, 20d / 3780 * 3600), new(eGood.Schnapps, 20d / 9450 * 3600), new(eGood.RoughCloak, 20d / 10800 * 3600), new(eGood.Tea, 20d / 14000 * 3600), new(eGood.Bread, 20d / 33600 * 3600)];
	private protected override string IconName => "AdeptsQuarter.png";
}