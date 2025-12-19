namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Pioneers;

internal class PioneersHut : PioneersBuilding, IPopulationBuilding
{
	public static bool BoostProduction { get; set; } = true;
	public override double Minutes => 60;
	public override Material? Production => new(eGood.Militia, 3 * (BoostProduction ? 1.2 : 1));
	public override Material[] Consumption { get; } = [new(eGood.Fish, 10d / 3780 * 3600), new(eGood.Sausage, 10d / 10800 * 3600), new(eGood.Cider, 10d / 9450 * 3600)];
	private protected override string IconName => "PioneersHut.png";
}