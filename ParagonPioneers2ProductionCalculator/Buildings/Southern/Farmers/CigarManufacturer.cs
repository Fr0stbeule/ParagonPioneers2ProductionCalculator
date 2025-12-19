namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class CigarManufacturer : FarmersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Cigar, 1);
	public override Material[] Consumption { get; } = [new(eGood.Tobacco, 2)];
	private protected override string IconName => "CigarManufacturer.png";
}