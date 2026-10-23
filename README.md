<<<<<<< HEAD
# ISC-103-Examen-U1-VillamilEverth.
Examein Unidad I - POO 
=======
##POO EXAMEN UNIDAD 1 
#Everth Armando Villamil Ruiz - 20152100055
>>>>>>> a6b4a8e (Se agregaron los archivos desde el ejercicio 1 al 2)
Parte única — Ejercicios prácticos (65 puntos)
Ejercicio 1 — Cotizador de envíos · 10 puntos
Una empresa de mensajería cobra el envío según la zona de destino, el peso del paquete, el tipo de servicio y el valor
declarado. Escriba un programa de consola que solicite el nombre del cliente, la zona (1 = local, 2 = departamental, 3 =
nacional), el peso en kilogramos, el tipo de servicio (1 = estándar, 2 = express, 3 = mismo día) y el valor declarado del paquete.
Tarifas:
● Zona 1 (local): L. 60.00; zona 2 (departamental): L. 100.00; zona 3 (nacional): L. 150.00.
● Recargo por peso: hasta 1 kg, L. 0.00; más de 1 y hasta 5 kg, L. 40.00; más de 5 y hasta 10 kg, L. 80.00; más de 10 kg, L. 140.00.
● Servicio: estándar +0%; express +25%; mismo día +50% sobre la suma de la base y el recargo por peso.
● Seguro: si el valor declarado supera L. 5,000.00, agregue el 2% de ese valor.
● Descuento: si el subtotal supera L. 700.00, aplique 5%.
Requisitos:
● Valide la zona (1 a 3), el peso (mayor que cero), el tipo de servicio (1 a 3) y el valor declarado (mayor o igual que cero).
● Use decimal para todos los montos, switch para la zona y el servicio, y if/else para el peso, el seguro y el descuento.
● Use el operador ternario para mostrar «Envío asegurado» o «Envío sin seguro».
● Muestre un recibo con el detalle de cada concepto y el total a pagar, con dos decimales y formato de moneda.
Ejercicio 2 — Simulador de carga de combustible · 10 puntos
Una estación de servicio desea simular la carga de combustible de un vehículo. El programa debe solicitar el tipo de
combustible (1 = regular, 2 = premium, 3 = diésel) y la cantidad de litros solicitada (máximo 60).
Precios por litro:
● Regular: L. 28.50. Premium: L. 32.00. Diésel: L. 26.75.
● La bomba carga en bloques de 5 litros. Use un ciclo while para acumular los litros hasta alcanzar la cantidad solicitada; el
último bloque puede ser parcial.
● En cada iteración muestre cuántos litros se han cargado.
Al finalizar:
● Calcule el subtotal multiplicando los litros cargados por el precio del combustible.
● Aplique un descuento del 5% si el subtotal es mayor o igual a L. 1,500.00; del 3% si es mayor o igual a L. 1,000.00; en caso
contrario, no aplique descuento.
● Muestre el total de litros, el subtotal, el descuento y el total a pagar.
Requisitos:
● Valide el tipo de combustible (1 a 3) y la cantidad de litros (mayor que cero y menor o igual que 60).
● Use switch para el tipo de combustible, while para la carga y if/else para el descuento.
Ejercicio 3 — Control de asistencia a un taller · 11 puntos
Un taller de capacitación tiene 10 participantes. En el código, declare un arreglo de cadenas con los nombres de los
participantes y un arreglo de booleanos con su asistencia (true = asistió, false = faltó). Use datos precargados; no los solicite
al usuario.
El programa debe:
● Mostrar la lista de participantes con la leyenda «Asistió» o «Faltó», usando un ciclo for.
● Contar y mostrar cuántos asistieron y cuántos faltaron.
● Calcular y mostrar el porcentaje de asistencia.
● Mostrar los nombres de quienes faltaron usando un ciclo foreach.
● Solicitar un nombre y buscarlo con un ciclo for. Indicar si se encontró, la posición (empezando en 1) y si asistió. Si no se
encontró, mostrar un mensaje.
● Mostrar los nombres en orden inverso usando un ciclo for que recorra el arreglo desde el último índice hasta el primero.

Página 3 de 4

Requisitos:
● Valide que el nombre ingresado para la búsqueda no esté vacío.
● Use arreglos, for, foreach, condicionales y comparación de cadenas.
● No use LINQ ni métodos que oculten el recorrido manual del arreglo.
Ejercicio 4 — Fila de atención de una clínica · 13 puntos
Una clínica atiende pacientes por orden de llegada, pero primero atiende los casos urgentes. Implemente un programa con
dos listas: una para pacientes urgentes y otra para pacientes normales. El programa debe mostrar un menú que se repita
hasta que el usuario elija salir.
Opciones del menú:
● Registrar paciente: solicite el nombre y la prioridad (1 = urgente, 2 = normal). Valide que el nombre no esté vacío y que no
exista en ninguna de las dos listas. Agregue el paciente al final de la lista correspondiente.
● Atender siguiente: si hay pacientes urgentes, atienda al primero de esa lista; si no, atienda al primero de la lista normal.
Muestre el nombre atendido y la prioridad. Si no hay pacientes, muestre un mensaje.
● Mostrar fila: muestre los pacientes urgentes numerados, luego los normales numerados y el total de pacientes en espera.
● Buscar paciente: solicite un nombre e indique si está en la fila urgente o normal, su posición (empezando en 1) y cuántos
pacientes hay delante.
● Mostrar cantidad: indique cuántos pacientes urgentes, cuántos normales y cuántos hay en total.
● Salir.
Requisitos:
● Use List<string> para las dos filas, un ciclo while para el menú y switch para las opciones.
● Use los métodos Add, RemoveAt(0), Contains, IndexOf y la propiedad Count.
● Valide la opción del menú y todos los datos ingresados.
Ejercicio 5 — Inventario de una papelería · 16 puntos
Una papelería desea controlar su inventario. Implemente un programa con tres listas paralelas: nombres de productos,
existencias y precios unitarios. El programa debe mostrar un menú que se repita hasta que el usuario elija salir.
Opciones del menú:
● Registrar producto: solicite nombre, existencia inicial y precio unitario. Valide que el nombre no esté vacío ni repetido, que
la existencia sea mayor o igual que cero y que el precio sea mayor que cero.
● Vender producto: solicite nombre y cantidad. Valide que el producto exista y que haya suficiente existencia. Descuente la
cantidad y muestre el total de la venta (cantidad por precio). Si no hay suficiente, muestre la existencia disponible.
● Abastecer producto: solicite nombre y cantidad. Valide que el producto exista y que la cantidad sea mayor que cero. Sume
la cantidad a la existencia.
● Mostrar inventario: para cada producto muestre nombre, existencia, precio y valor total en inventario (existencia por
precio). Al final, muestre el valor total del inventario.
● Mostrar alertas: muestre los productos con existencia menor o igual a 5 y el producto con el mayor valor total en inventario.
● Salir.
Requisitos:
● Use List<string>, List<int> y List<decimal>; recorra las listas con for o foreach.
● Use Contains e IndexOf para buscar productos y valide todas las entradas.
● Muestre los montos con dos decimales y formato de moneda.