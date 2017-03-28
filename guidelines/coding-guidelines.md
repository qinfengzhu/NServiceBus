## Performance related

For public facing interfaces we favor read-only collections and enumerables. For internal types we favor speed and allocation reduction. Avoid using collection interfaces internally.

### In hot paths

* Avoid allocations
* Avoid using `System.Linq`
* Avoid using `foreach` over collections that do not have a struct enumerator
