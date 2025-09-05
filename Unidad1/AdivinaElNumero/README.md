PASOS DEL PROGRAMA
Al iniciar el programa nos pedira ingresar un numero (lo ingresamos)
El programa nos dira si "el numero que debemos adivinar es menor o mayor"
Si nos equivocamos nos restara una vida
Al ingresar el numero correcto nos dira que hemos adivinado el numero, los intentos que nos tomo y cuantas vidas nos quedaron (un pequeño error a solucionar)

Tenemos 2 excepciones, una de caracteres no validos y otra de desbordamiento.
En caracteres no validos (FormatExeption) hace que el programa no se cierre si el usuario llega a ingresar algun caracter que no sea un numero entero
En (OverFlowExeption) no nos deja ingresar un numero muy grande o un numero muy pequeño.

si todo sale bien y se adivina el numero, mostrara un mensaje de ¡FELICITACIONES!
si se pierde se mostrara un mensaje de que "has perdido".
