using System.Diagnostics;
using ParagonPioneers2ProductionCalculator.Tiles;

namespace ParagonPioneers2ProductionCalculator.Buildings;

[DebuggerDisplay("{this.GetType().Name}")]
public abstract class AbstractBuilding
{
	private readonly Dictionary<eGood, SupplierChoice> _supplierChoices = [];

	protected AbstractBuilding()
	{
		foreach (var consumption in this.Consumption)
		{
			SupplierChoice supplierChoice = new(SupplierConfiguration.GetSupplier(consumption.Good));
			supplierChoice.SelectedSupplier = supplierChoice.PotentialSupplier
				.OrderByDescending(x => x.GetType().BaseType?.BaseType == this.GetType().BaseType?.BaseType)
				.First();

			_supplierChoices.Add(consumption.Good, supplierChoice);
		}
	}

	public abstract double Minutes { get; }
	public abstract Material? Production { get; }
	public abstract Material[] Consumption { get; }
	public virtual TileRequirement? TileRequirement { get; }
	public string IconLocation => Path.Combine("Buildings", this.Region, this.IconName);
	public ICollection<SupplierChoice> SupplierChoices => _supplierChoices.Values;
	public double Amount { get; set; }
	private protected abstract string Region { get; }
	private protected abstract string IconName { get; }

	public void UpdateAmount(double difficultyMultiplier)
	{
		foreach (var consumption in this.Consumption)
		{
			_supplierChoices[consumption.Good].PotentialSupplier.ForEach(x => processProducer(consumption, x));
		}

		if (this.TileRequirement != null)
		{
			this.TileRequirement.Tile.Amount = this.TileRequirement.Amount * this.Amount;
		}

		void processProducer(Material consumption, AbstractBuilding producer)
		{
			double multi = this is IPopulationBuilding ? difficultyMultiplier : 1;
			double consumptionPerMinute = multi * this.Amount * consumption.Amount / this.Minutes;
			double productionPerMinute = producer.Production!.Amount / producer.Minutes;
			producer.Amount = Math.Round(consumptionPerMinute / productionPerMinute, 2, MidpointRounding.AwayFromZero);
			producer.UpdateAmount(difficultyMultiplier);
		}
	}
}