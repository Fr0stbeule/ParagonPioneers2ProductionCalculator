namespace ParagonPioneers2ProductionCalculator.Buildings;

public class RegionalBuilding : AbstractBuilding
{
	public override double Minutes => throw new Exception();
	public override Material? Production => null;
	public override Material[] Consumption { get; } = [];
	private protected override string Region => "../Regions";
	private protected override string IconName => "Regional.png";
}