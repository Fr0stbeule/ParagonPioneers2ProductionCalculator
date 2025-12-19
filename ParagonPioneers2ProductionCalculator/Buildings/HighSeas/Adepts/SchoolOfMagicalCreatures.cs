namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Adepts;

internal class SchoolOfMagicalCreatures : AdeptsBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Pegasus, 1)];
	private protected override string IconName => "SchoolOfMagicalCreatures.png";
}