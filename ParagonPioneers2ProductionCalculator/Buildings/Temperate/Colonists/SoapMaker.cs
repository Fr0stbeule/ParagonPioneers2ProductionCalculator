namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class SoapMaker : ColonistsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Soap, 1);
	public override Material[] Consumption { get; } = [new(eGood.Potash, 1), new(eGood.Tallow, 1)];
	private protected override string IconName => "SoapMaker.png";
}