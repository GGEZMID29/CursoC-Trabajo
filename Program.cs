Console.Clear();
/*Logica Booleana
/*Operadores Relacionales
>: Mayor que.
<: Menor que.
>=: Mayor o igual que.
<=: Menor o igual que.
==: Igual a.
!=: Diferente de.
Console.Clear();
var cantidad1 = 5;
var cantidad2 = 5;

var cantidad1IgualACantidad2 = cantidad1 == cantidad2; // true

var cantidad1EsDiferenteACantidad2 = cantidad1 != cantidad2; // false

Console.WriteLine($"Son {cantidad1} y {cantidad2} iguales? {cantidad1IgualACantidad2}");
Console.WriteLine($"Son {cantidad1} y {cantidad2} diferentes? {cantidad1EsDiferenteACantidad2}");

var esCantidad1MenorQue10 = cantidad1 < 10; // true
var esCantidad1MayorQue10 = cantidad1 > 10; // false

var esCantidad1MenorOIgualQue10 = cantidad1 <= 10; // true
var esCantidad1MayorOIgualQue10 = cantidad1 >= 10; // false

string? nombre1 = null;
var nombre2 = "Felipe";

var NombresIguales = nombre1 == nombre2; //false

var esNombre1Nulo = nombre1 is null; //false
var esNombre1NoNulo = nombre1 is not null; //true

Console.WriteLine("Es nombre 1 igual a nulo? " + esNombre1Nulo);
Console.WriteLine("Es nombre 1 diferente de nulo? " + esNombre1NoNulo);
*/

/*Operadores Booleanos Condicionales
var c1 = 6;

// true && true => true
// true && false => false 
// false && true => false 
// false && false => false

var estaEntre5y10 = c1 > 5 && c1 < 10;
Console.WriteLine($"¿Está el {c1} entre 5 y 10? {estaEntre5y10}");

// true || true => true
// true || false => true
// false || true => true
// false || false => false


var cantidad1Es5o6 = c1 == 5 || c1 == 6; // true
Console.WriteLine($"¿Es {c1} igual a 5 o 6? {cantidad1Es5o6}");

string? apellido = null;

var estaElApellidoEnMayusculas = apellido is not null && apellido == apellido.ToUpper();

Console.WriteLine("Está el string en mayúsculas? " + estaElApellidoEnMayusculas);
*/

/*Sentencias de Seleccion*/
