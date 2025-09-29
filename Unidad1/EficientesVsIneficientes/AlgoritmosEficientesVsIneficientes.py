import random
import time

# FUNCIONES DE BÚSQUEDA
def busqueda_lineal(lista, objetivo):
    for indice, elemento in enumerate(lista):
        if elemento == objetivo:
            return indice
    return -1

def busqueda_binaria(lista, objetivo):
    izquierda, derecha = 0, len(lista) - 1
    while izquierda <= derecha:
        medio = izquierda + (derecha - izquierda) // 2
        if lista[medio] == objetivo:
            return medio
        elif objetivo < lista[medio]:
            derecha = medio - 1
        else:
            izquierda = medio + 1
    return -1

# FUNCIONES DE ORDENAMIENTO
def bubble_sort(secuencia):
    n = len(secuencia)
    for i in range(n - 1):
        intercambiado = False
        for j in range(0, n - i - 1):
            if secuencia[j] > secuencia[j + 1]:
                secuencia[j], secuencia[j + 1] = secuencia[j + 1], secuencia[j]
                intercambiado = True
        if not intercambiado:
            break
    return secuencia

def mezclar(izquierda, derecha):
    resultado = []
    i = j = 0
    while i < len(izquierda) and j < len(derecha):
        if izquierda[i] <= derecha[j]:
            resultado.append(izquierda[i])
            i += 1
        else:
            resultado.append(derecha[j])
            j += 1
    resultado.extend(izquierda[i:])
    resultado.extend(derecha[j:])
    return resultado

def merge_sort(secuencia):
    if len(secuencia) <= 1:
        return secuencia
    medio = len(secuencia) // 2
    izquierda = merge_sort(secuencia[:medio])
    derecha = merge_sort(secuencia[medio:])
    return mezclar(izquierda, derecha)

# --- FUNCIONES DE FIBONACCI ---
def fib_recursivo(n):
    if n <= 1:
        return n
    return fib_recursivo(n - 1) + fib_recursivo(n - 2)

def fib_iterativo(n):
    if n <= 1:
        return n
    a, b = 0, 1
    for _ in range(2, n + 1):
        a, b = b, a + b
    return b

# Programa principal

def iniciar_busqueda():
    print("\nMetodo de Búsqueda")
    try:
        tamano = int(input("¿Cuántos elementos quieres en la lista? "))
        if tamano <= 0: tamano = 10
    except ValueError:
        tamano = 10
    
    lista = sorted(random.sample(range(1, tamano * 10), k=tamano))
    print(f"Lista generada (ordenada): {tamano}")

    while True:
        try:
            objetivo = int(input("Introduce el número a buscar (presiona 0 para volver): "))
            if objetivo == 0: break
        except ValueError:
            print("No valido")
            continue

        print("1. Búsqueda Lineal o 2. Búsqueda Binaria")
        opcion = input("Elige una opción: ")
        
        funcion_busqueda, nombre_func = (busqueda_lineal, "Lineal") if opcion == '1' else (busqueda_binaria, "Binaria")

        inicio = time.perf_counter()
        resultado = funcion_busqueda(lista, objetivo)
        duracion = time.perf_counter() - inicio
        
        if resultado != -1: print(f" Encontrado en la posición {resultado}.")
        else: print(" Numero No encontrado.")
        print(f" Búsqueda {nombre_func} tardó {duracion * 1_000_000:.6f} microsegundos.")
        print("-" * 20)

def iniciar_ordenamiento():
    print("\nLaboratorio de Ordenamiento")
    try:
        tamano = int(input("¿Cuántos elementos quieres en la lista? "))
        if tamano <= 1: tamano = 10
    except ValueError:
        tamano = 10
    
    lista_original = random.sample(range(1, tamano * 10), k=tamano)
    print(f"Generada lista con {tamano} elementos.")
    
    while True:
        print("\n1. Bubble Sort | 2. Merge Sort | 3. Volver al menú principal")
        opcion = input("Elige una opción: ")

        if opcion == '3': break
        if opcion not in ['1', '2']:
            print("Opción inválida.")
            continue

        func_ord, nombre_func = (bubble_sort, "Bubble Sort") if opcion == '1' else (merge_sort, "Merge Sort")
        
        lista_a_ordenar = list(lista_original) # Copia para una comparación justa
        
        print(f"Ordenando con {nombre_func}...")
        inicio = time.perf_counter()
        lista_ordenada = func_ord(lista_a_ordenar)
        duracion = time.perf_counter() - inicio

        print(f"Lista ordenada. (Primeros 20: {lista_ordenada[:20]}...)")
        print(f" {nombre_func} tardó {duracion:.6f} segundos.")
        print("-" * 20)

def iniciar_fibonacci():
    print("\nMetodo Fibonacci")
    while True:
        try:
            n = int(input("Introduce el número 'n' para Fibonacci (o -1 para volver): "))
            if n == -1: break
            if n < 0: 
                print("Debe ser un número no negativo.")
                continue
        except ValueError:
            print("Entrada inválida.")
            continue
        
        if n > 35: print("  ADVERTENCIA: n > 35 será muy lento para el método recursivo.")

        print("1. Método Recursivo | 2. Método Iterativo")
        opcion = input("Elige una opción: ")

        func_fib, nombre_func = (fib_recursivo, "Recursivo") if opcion == '1' else (fib_iterativo, "Iterativo")
        
        print(f"Calculando con método {nombre_func}...")
        inicio = time.perf_counter()
        resultado = func_fib(n)
        duracion = time.perf_counter() - inicio

        print(f"Fibonacci({n}) = {resultado}")
        print(f"Cálculo {nombre_func} tardó {duracion:.6f} segundos.")
        print("-" * 20)

# MENÚ 
if __name__ == "__main__":
    while True:
        print("\n--Algoritmos--")
        print(" ")
        print("1. Algoritmos de Búsqueda")
        print("2. Algoritmos de Ordenamiento")
        print("3. Algoritmos de Fibonacci")
        print("4. Salir")
        
        opcion_principal = input("Selecciona una categoría: ")
        
        if opcion_principal == '1':
            iniciar_busqueda()
        elif opcion_principal == '2':
            iniciar_ordenamiento()
        elif opcion_principal == '3':
            iniciar_fibonacci()
        elif opcion_principal == '4':
            print("\n¡Hasta luego! Gracias por experimentar.")
            break
        else:
            print("Opción no válida. Por favor, elige de 1 a 4.")