namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Apprentices;

internal class CloakTailoring : ApprenticeBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.RoughCloak, 1);
	public override Material[] Consumption { get; } = [new(eGood.Linen, 1)];
	private protected override string IconName => "CloakTailoring.png";
}