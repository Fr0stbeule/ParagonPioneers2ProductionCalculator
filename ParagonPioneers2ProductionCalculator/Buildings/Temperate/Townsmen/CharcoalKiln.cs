namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class CharcoalKiln : TownsmenBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Coal, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 8)];
	private protected override string IconName => "CharcoalKiln.png";
}