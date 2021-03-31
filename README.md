# CSharp.6.PLINQ

Para usar paralelizacion se debe usar: 
```csharp
var evenNums = from num in source.AsParallel()
```

es recomendable usar para casos complejos

para casos simples en vez de mejorar rendimiento lo empeora

Ejemplo
```csharp 
var queryA = from num in numberList.AsParallel()  
             select ExpensiveFunction(num); //good for PLINQ  

var queryB = from num in numberList.AsParallel()  
             where num % 2 > 0  
             select num; //not as good for PLINQ  
```
