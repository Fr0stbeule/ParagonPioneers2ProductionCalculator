namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Adepts;

internal class AlchemySchool : AdeptsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Herbs, 4), new(eGood.Cauldron, 1)];
	private protected override string IconName => "AlchemySchool.png";
}