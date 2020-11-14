Chain of responsability tiene como idea principal de que cualquiera de los receptores puedan responder a la
peticion en funcion u orden de algun criterio establecido. Asigna la resposabilidad a objetos describiendo el 
flujo de control complejo.

Cuando lo utilizo? Cuando una peticion debe ser manejada por uno o varios objetos dentro de un sistema.

Problema. Para ver la ejecucion del programa realizaremos lo siguiente: Simularemos una tienda de X productos donde
una compra tendra que ser aprobada segun el monto, si el monto es <100 lo aprobara el vendedor, si es <=100 lo
procesara el gerente, si es <5000 lo aprobara el Director y si el monto es >=5000 tendra que psar por la
autorizacion de la comision.

					Jerarquia:
									Comision
									Director
									Gerente
									Vendedor