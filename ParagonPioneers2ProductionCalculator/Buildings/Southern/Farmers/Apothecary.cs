namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class Apothecary : FarmersBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.MedicinePouch, 1);
	public override Material[] Consumption { get; } = [new(eGood.Leather, 1), new(eGood.Rum, 3)];
	private protected override string IconName => "Apothecary.png";
}