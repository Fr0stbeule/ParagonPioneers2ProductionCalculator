namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class ShieldGuardianTemple : WorkersBuilding
{
	public override double Minutes => 20;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Slinger, 4), new(eGood.LongShield, 1)];
	private protected override string IconName => "ShieldGuardianTemple.png";
}