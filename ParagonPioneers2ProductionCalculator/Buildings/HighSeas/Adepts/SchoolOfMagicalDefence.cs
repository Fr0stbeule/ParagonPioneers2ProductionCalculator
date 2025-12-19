namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Adepts;

internal class SchoolOfMagicalDefence : AdeptsBuilding
{
	public override double Minutes => 0.5;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Wand, 1)];
	private protected override string IconName => "SchoolOfMagicalDefence.png";
}