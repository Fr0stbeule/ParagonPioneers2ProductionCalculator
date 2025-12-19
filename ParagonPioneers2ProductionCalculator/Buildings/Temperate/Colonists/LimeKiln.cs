namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class LimeKiln : ColonistsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Quicklime, 1);
	public override Material[] Consumption { get; } = [new(eGood.Limestone, 1), new(eGood.Wood, 4)];
	private protected override string IconName => "LimeKiln.png";
}