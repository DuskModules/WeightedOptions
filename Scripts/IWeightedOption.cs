
namespace DuskModules.WeightedOptions {

  /// <summary> Interface of weighted option </summary>
  public interface IWeightedOption {

    /// <summary> Whether it is an option and can be chosen or not </summary>
    /// <param name="caller"> Object that called it </param>
    /// <returns> Whether it can be chosen or not </returns>
    bool IsAnOption(object caller);

    /// <summary> Gets the weight of the option </summary>
    /// <returns> The weight of the option </returns>
    float GetWeight();
  }
}