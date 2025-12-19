using System.Diagnostics;

namespace ParagonPioneers2ProductionCalculator.Buildings;

[DebuggerDisplay("{SelectedSupplier.GetType().Name}")]
public class SupplierChoice(List<AbstractBuilding> potentialSupplier)
{
	public AbstractBuilding SelectedSupplier { get; set; } = potentialSupplier.First();
	public List<AbstractBuilding> PotentialSupplier { get; } = potentialSupplier;
	public bool Ignore { get; set; }
}