using UnityEngine;
using System.Collections.Generic;
using DuskModules.WeightedOptions; 
// Not within the namespace, so the methods are accessible without using the namespace in scripts outside of those implementing the WeightedOptions.

/// <summary> Static class containing extension methods for IWeightedOption lists. </summary>
public static class WeightedOptionExtensionMethods {

  /// <summary> Randomly selects one weighted option from the list </summary>
  /// <param name="options"> Possible options </param>
  /// <param name="caller"> Object that called it </param>
  /// <returns> The randomly selected option </returns>
  public static T GetWeightedRandom<T>(this List<T> options, object caller = null) where T : IWeightedOption {
    float total = 0;
    for (int i = 0; i < options.Count; i++) {
      if (options[i].IsAnOption(caller)) {
        total += options[i].GetWeight();
      }
    }
    float random = Random.Range(0, total);
    float prog = 0;
    for (int i = 0; i < options.Count; i++) {
      if (options[i].IsAnOption(caller)) {
        prog += options[i].GetWeight();
        if (random < prog) {
          return options[i];
        }
      }
    }
    return default(T);
  }

  /// <summary> Counts the total options available in this list and returns it. </summary>
  /// <param name="options"> Possible options </param>
  /// <param name="caller"> Object that called it </param>
  /// <returns> Amount of options available </returns>
  public static int GetWeightedRandomCount<T>(this List<T> options, object caller = null) where T : IWeightedOption {
    int count = 0;
    for (int i = 0; i < options.Count; i++) {
      if (options[i].IsAnOption(caller)) {
        count++;
      }
    }
    return count;
  }
}