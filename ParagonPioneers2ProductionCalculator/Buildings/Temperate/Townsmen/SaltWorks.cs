namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class SaltWorks : TownsmenBuilding
{
	public override double Minutes => 12;
	public override Material? Production { get; } = new(eGood.Salt, 2);
	public override Material[] Consumption { get; } = [new(eGood.Coal, 1), new(eGood.RockSalt, 1)];
	private protected override string IconName => "SaltWorks.png";
}