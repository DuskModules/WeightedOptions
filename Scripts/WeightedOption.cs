
namespace DuskModules.WeightedOptions {

  /// <summary> Serializable weighted option class for use in Inspector Editor adjustable lists. </summary>
  public class WeightedOption : IWeightedOption {

    /// <summary> Weight of selection </summary>
    public float weight;

    /// <summary> Whether it can select or not </summary>
    /// <param name="caller"> Object that called it </param>
    /// <returns> Whether it can select or not </returns>
    public virtual bool IsAnOption(object caller) {
      return (weight > 0);
    }
    /// <summary> Gets the chance of selection </summary>
    /// <returns> Gets the chance of selection </returns>
    public virtual float GetWeight() {
      return weight;
    }
  }
}