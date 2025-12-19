namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class BuffaloPasture : WorkersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.WaterBuffalo, 1)];
	private protected override string IconName => "BuffaloPasture.png";
}